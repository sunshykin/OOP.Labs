using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Numerics;
using System.Text;
using System.Text.RegularExpressions;
using OOP.Labs.Common.Models;

namespace OOP.Labs.Lab8.Models
{
    public class StreamableComplex : INumerable, IStreamable
    {
        public Complex Value;

        private static string _regexPattern = @"^([-+]?(?:\d+|\d*\.\d+))?[-+]?(\d+|\d*\.\d+)?[ij]$";
        public static Regex RegEx = new Regex(_regexPattern);

        public StreamableComplex(string num)
        {
            var strNum = num.Replace(',', '.');

            Match match = RegEx.Match(strNum);

            if (match.Groups.Count == 3 && match.Groups[2].Value.IndexOf('.') != 0)
            {
                int index = strNum.LastIndexOf(match.Groups[2].Value);
                index = index < 1 ? 0 : index - 1;
                int multImg = strNum[index] == '-' ? -1 : 1;
                Value = new Complex(double.Parse(match.Groups[1].Value, CultureInfo.InvariantCulture),
                    double.Parse(match.Groups[2].Value, CultureInfo.InvariantCulture) * multImg);
            }
            else
            {
                int mult = strNum.Contains("-") ? -1 : 1;
                strNum = strNum.Replace("+", "").Replace("-", "").Trim(' ');
                if (strNum.Contains("i"))
                {
                    strNum = strNum.Replace("i", "");
                    if (double.TryParse(strNum, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double img))
                        Value = new Complex(0, img * mult);
                    else
                        Value = new Complex(double.NaN, 0);
                }
                else
                {
                    if (double.TryParse(strNum, NumberStyles.AllowDecimalPoint, CultureInfo.InvariantCulture, out double real))
                        Value = new Complex(real * mult, 0);
                    else
                        Value = new Complex(double.NaN, double.NaN);
                }
            }
        }

        public StreamableComplex(Complex val)
        {
            Value = val;
        }

        #region INumerable

        public INumerable Multiply(INumerable num)
        {
            if (num is StreamableComplex compl)
                return new StreamableComplex(Value * compl.Value);
            else
                return new StreamableComplex(0);
        }

        public INumerable MultiplyByNumber(double num)
        {
            return new StreamableComplex(Value * num);
        }

        public INumerable Divide(INumerable num)
        {
            if (num is StreamableComplex compl)
                return new StreamableComplex(Value / compl.Value);
            else
                return new StreamableComplex(0);
        }

        public INumerable Add(INumerable num)
        {
            if (num is StreamableComplex compl)
                return new StreamableComplex(Value + compl.Value);
            else
                return new StreamableComplex(0);
        }

        public INumerable Subtract(INumerable num)
        {
            if (num is StreamableComplex compl)
                return new StreamableComplex(Value - compl.Value);
            else
                return new StreamableComplex(0);
        }

        public INumerable Sqrt()
        {
            return new StreamableComplex(Complex.Sqrt(Value));
        }

        #endregion

        #region IStreamable

        public StreamWriter OutStream
        {
            get
            {
                var stream = new StreamWriter(Console.OpenStandardOutput());
                stream.Write(Value.ToString());
                return stream;
            }
        }

        public StreamReader InStream
        {
            get
            {
                var stream = new StreamReader(Console.OpenStandardInput());
                Value = new StreamableComplex(stream.ReadLine()).Value;
                return stream;
            }
        }

        #endregion
    }
}
