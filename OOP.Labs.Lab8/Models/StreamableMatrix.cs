using System;
using System.IO;
using System.Linq;
using OOP.Labs.Common.Models;

namespace OOP.Labs.Lab8.Models
{
    public class StreamableMatrix : Matrix<StreamableComplex>, INumerable, IStreamable
    {
        /// <summary>
        /// Размерность матрицы
        /// </summary>
        private int Dimension;

        public StreamableMatrix(int n) : base(n, n)
        {
            Dimension = n;
            for (int i = 0; i < Dimension; i++)
            {
                for (int j = 0; j < Dimension; j++)
                {
                    Value[i, j] = new StreamableComplex(0);
                }
            }
        }

        public StreamableMatrix(StreamableComplex[,] matr) : base(matr)
        {
            Dimension = Value.GetLength(0);
        }

        #region INumerable

        public INumerable Multiply(INumerable num)
        {
            if (num is StreamableMatrix matr)
            {
                var newMatrix = new StreamableComplex[Dimension, Dimension];
                for (int i = 0; i < Dimension; i++)
                    newMatrix[i, i] = Value[i, i].Multiply(matr.Value[i, i]) as StreamableComplex;

                return new StreamableMatrix(newMatrix);
            }
            else
                return new StreamableMatrix(1);
        }

        public INumerable MultiplyByNumber(double num)
        {
            var newMatrix = new StreamableComplex[Dimension, Dimension];
            for (int i = 0; i < Dimension; i++)
                newMatrix[i, i] = Value[i, i].MultiplyByNumber(num) as StreamableComplex;

            return new StreamableMatrix(newMatrix);
        }

        public INumerable Divide(INumerable num)
        {
            if (num is StreamableMatrix matr)
            {
                var newMatrix = new StreamableComplex[Dimension, Dimension];
                for (int i = 0; i < Dimension; i++)
                    newMatrix[i, i] = Value[i, i].Divide(matr.Value[i, i]) as StreamableComplex;

                return new StreamableMatrix(newMatrix);
            }
            else
                return new StreamableMatrix(1);
        }

        public INumerable Add(INumerable num)
        {
            if (num is StreamableMatrix matr)
            {
                var newMatrix = new StreamableComplex[Dimension, Dimension];
                for (int i = 0; i < Dimension; i++)
                    newMatrix[i, i] = Value[i, i].Add(matr.Value[i, i]) as StreamableComplex;

                return new StreamableMatrix(newMatrix);
            }
            else
                return new StreamableMatrix(1);
        }

        public INumerable Subtract(INumerable num)
        {
            if (num is StreamableMatrix matr)
            {
                var newMatrix = new StreamableComplex[Dimension, Dimension];
                for (int i = 0; i < Dimension; i++)
                    newMatrix[i, i] = Value[i, i].Subtract(matr.Value[i, i]) as StreamableComplex;

                return new StreamableMatrix(newMatrix);
            }
            else
                return new StreamableMatrix(1);
        }

        public INumerable Sqrt()
        {
            var newMatrix = new StreamableComplex[Dimension, Dimension];
            for (int i = 0; i < Dimension; i++)
                newMatrix[i, i] = Value[i, i].Sqrt() as StreamableComplex;

            return new StreamableMatrix(newMatrix);
        }

        #endregion

        #region IStreamable

        public StreamWriter OutStream
        {
            get
            {
                var stream = new StreamWriter(Console.OpenStandardOutput());
                for (int i = 0; i < Dimension; i++)
                {
                    var row = Value.Cast<StreamableComplex>().Skip(Dimension * i).Take(Dimension).Select(c => c?.Value.ToString() ?? "0");
                    stream.Write(String.Join("\t", row));

                    if (i < Dimension - 1)
                        stream.WriteLine();
                }
                return stream;
            }
        }

        public StreamReader InStream
        {
            get
            {
                var stream = new StreamReader(Console.OpenStandardInput());
                for (int i = 0; i < Dimension; i++)
                {
                    for (int j = 0; j < Dimension; j++)
                    {
                        if (i == j)
                            Value[i, j] = new StreamableComplex(stream.ReadLine());
                        else
                            Value[i, j] = new StreamableComplex(0);
                    }
                }
                return stream;
            }
        }

        #endregion
    }
}
