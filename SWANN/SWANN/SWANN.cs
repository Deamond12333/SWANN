using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWANN
{
    class SWANN
    {
        public SWANN(string function, double x0, double t)
        {
            int k = 0;
        }

        private double parseFunction(string function, double x)
        {
            double result = 0;
            for (int i = 0; i < function.Length; ++i)
            {
                if (function.Substring(i, 1) == "^")
                {
                    int begin = i + 1;
                    int end = 0;
                    for (int j = begin; j < function.Length; ++j)
                    {
                        if (function.Substring(i, 1) == " ")
                            result += Math.Pow(x, double.Parse(function.Substring(begin, end - 1)));
                        else end++;
                    }
                }
            }
            return result;
        }
    }
}
