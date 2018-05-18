using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using OOP.Labs.Common.Models;

namespace OOP.Labs.Lab8.Models
{
    public class StreamableNumber : INumerable, IStreamable
    {
        public double Value;

        public StreamableNumber(object num)
        {
            var strNum = num.ToString().Replace('.', ',');

            double.TryParse(strNum, out Value);
        }


        #region INumerable

        public INumerable Multiply(INumerable num)
        {
            if (num is StreamableNumber)
                return new StreamableNumber(Value * ((StreamableNumber)num).Value);
            else
                return new StreamableNumber(0);
        }

        public INumerable MultiplyByNumber(double num)
        {
            return new StreamableNumber(Value * num);
        }

        public INumerable Divide(INumerable num)
        {
            if (num is StreamableNumber)
                return new StreamableNumber(Value / ((StreamableNumber)num).Value);
            else
                return new StreamableNumber(0);
        }

        public INumerable Add(INumerable num)
        {
            if (num is StreamableNumber)
                return new StreamableNumber(Value + ((StreamableNumber)num).Value);
            else
                return new StreamableNumber(0);
        }

        public INumerable Subtract(INumerable num)
        {
            if (num is StreamableNumber)
                return new StreamableNumber(Value - ((StreamableNumber)num).Value);
            else
                return new StreamableNumber(0);
        }

        public INumerable Sqrt()
        {
            return new StreamableNumber(Math.Sqrt(Value));
        }

        #endregion

        #region IStreamable

        public StreamWriter OutStream
        {
            get
            {
                var stream = new StreamWriter(Console.OpenStandardOutput());
                stream.Write(Value);
                return stream;
            }
        }

        public StreamReader InStream
        {
            get
            {
                var stream = new StreamReader(Console.OpenStandardInput());
                Value = new StreamableNumber(stream.ReadLine()).Value;
                return stream;
            }
        }

        #endregion
    }
}
