using System;
using System.IO;
using OOP.Labs.Common.Models;
using OOP.Labs.Lab8.Models;

namespace OOP.Labs.Lab8
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inStream;
            StreamWriter outStream, standartStream = new StreamWriter(Console.OpenStandardOutput());

            #region RealNumber Polinom

            Console.WriteLine("Real Number Polinom:");

            #region Reading A coef

            Console.Write("a = ");
            var realA = new StreamableNumber(0);
            inStream = realA.InStream;
            Console.SetIn(inStream);

            #endregion

            #region Reading B coef

            Console.Write("b = ");
            var realB = new StreamableNumber(0);
            inStream = realB.InStream;
            Console.SetIn(inStream);

            #endregion

            #region Reading C coef

            Console.Write("c = ");
            var realC = new StreamableNumber(0);
            inStream = realC.InStream;
            Console.SetIn(inStream);

            #endregion

            var realPolinom = new SecondDegreePolynom<StreamableNumber>(realA, realB, realC);
            var realRoots = realPolinom.GetRoots();

            #region Writing Root1

            Console.Write("root1 = ");
            outStream = realRoots[0].OutStream;
            Console.SetOut(outStream);
            outStream.Flush();

            Console.SetOut(standartStream);
            Console.WriteLine();

            #endregion

            #region Writing Root2

            Console.Write("root2 = ");
            standartStream.Flush();

            outStream = realRoots[1].OutStream;
            Console.SetOut(outStream);
            Console.WriteLine();
            outStream.Flush();

            Console.SetOut(standartStream);
            Console.WriteLine();

            #endregion

            #endregion

            #region ComplexNumber Polinom

            Console.WriteLine("Complex Number Polinom:");

            #region Reading A coef

            Console.Write("a = ");
            standartStream.Flush();
            var complexA = new StreamableComplex(0);
            inStream = complexA.InStream;
            Console.SetIn(inStream);

            #endregion

            #region Reading B coef

            Console.Write("b = ");
            standartStream.Flush();
            var complexB = new StreamableComplex(0);
            inStream = complexB.InStream;
            Console.SetIn(inStream);

            #endregion

            #region Reading C coef

            Console.Write("c = ");
            standartStream.Flush();
            var complexC = new StreamableComplex(0);
            inStream = complexC.InStream;
            Console.SetIn(inStream);

            #endregion

            var complexPolinom = new SecondDegreePolynom<StreamableComplex>(complexA, complexB, complexC);
            var complexRoots = complexPolinom.GetRoots();

            #region Writing Root1

            Console.Write("root1 = ");
            standartStream.Flush();

            outStream = complexRoots[0].OutStream;
            Console.SetOut(outStream);
            outStream.Flush();

            Console.SetOut(standartStream);
            Console.WriteLine();

            #endregion

            #region Writing Root2

            Console.Write("root2 = ");
            standartStream.Flush();

            outStream = complexRoots[1].OutStream;
            Console.SetOut(outStream);
            Console.WriteLine();
            outStream.Flush();

            Console.SetOut(standartStream);
            Console.WriteLine();

            #endregion

            #endregion

            #region DiagonalMatrix Polinom

            Console.WriteLine("Diagonal Matrix Polinom:");
            Console.Write("dim = ");
            standartStream.Flush();
            int dim = Int32.Parse(Console.ReadLine());

            #region Reading A coef

            Console.Write("a = ");
            standartStream.Flush();
            var matrixA = new StreamableMatrix(dim);
            inStream = matrixA.InStream;
            Console.SetIn(inStream);

            #endregion

            #region Reading B coef

            Console.Write("b = ");
            standartStream.Flush();
            var matrixB = new StreamableMatrix(dim);
            inStream = matrixB.InStream;
            Console.SetIn(inStream);

            #endregion

            #region Reading C coef

            Console.Write("c = ");
            standartStream.Flush();
            var matrixC = new StreamableMatrix(dim);
            inStream = matrixC.InStream;
            Console.SetIn(inStream);

            #endregion

            var matrixPolinom = new SecondDegreePolynom<StreamableMatrix> (matrixA, matrixB, matrixC);
            var matrixRoots = matrixPolinom.GetRoots();

            #region Writing Root1

            Console.Write("root1 = ");
            standartStream.Flush();

            outStream = matrixRoots[0].OutStream;
            Console.SetOut(outStream);
            outStream.Flush();

            Console.SetOut(standartStream);
            Console.WriteLine();

            #endregion

            #region Writing Root2

            Console.Write("root2 = ");
            standartStream.Flush();

            outStream = matrixRoots[1].OutStream;
            Console.SetOut(outStream);
            Console.WriteLine();
            outStream.Flush();

            Console.SetOut(standartStream);
            Console.WriteLine();

            #endregion

            #endregion

            Console.ReadKey();
        }
    }
}
