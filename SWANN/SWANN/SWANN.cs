using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace SWANN
{
    static class SWANN
    {
        public static double[] getInterval(string function)
        {
            Parser parser = new Parser();

            double y1, y2, y3, x0 = 0, t = 0.5;

            parser.Evaluate(parseFunction(function, x0 - t));
            y1 = parser.Result;
            parser.Evaluate(parseFunction(function, x0));
            y2 = parser.Result;
            parser.Evaluate(parseFunction(function, x0 + t));
            y3 = parser.Result;

            if (y1 >= y2 && y2 <= y3) return new double[2] { y1, y3 };

            if (y1 <= y2 && y2 >= y3) throw new Exception("Интервал расходится!");

            double a = 0;
            double b = 0;

            double d;

            if (y1 >= y2 && y2 >= y3)
            {
                d = t;
                a = x0;
                x0 += d;
            }
            else
            {
                d = -t;
                b = x0;
                x0 += d;
            }

            for (int i = 0; true; i++)
            {
                double x1 = x0;
                x0 += Math.Pow(2, i + 1) * d;
                parser.Evaluate(parseFunction(function, x0));
                double f0 = parser.Result;
                parser.Evaluate(parseFunction(function, x1));
                double f1 = parser.Result;

                if (f0 < f1)
                {
                    if (d > 0)
                    {
                        a = x1;
                    }
                    else
                    {
                        b = x1;
                    }
                }
                if (f0 >= f1)
                {
                    if (d > 0)
                    {
                        b = x0;
                    }
                    else
                    {
                        a = x0;
                    }

                    return new double[2] { a, b };
                }
            }
        }

        public static string parseFunction(string function, double x)
        {
            string result = null;
            for (int i = 0; i < function.Length; ++i)
            {
                if (Regex.IsMatch(function.Substring(i, 1), "^[a-zA-Z]$")) result += x;
                else result += function.Substring(i, 1);
            }
            return result;
        }
    }
}
