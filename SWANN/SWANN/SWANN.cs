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

        }
        public SWANN()
        {

        }

        public double parseFunction(string function, double x, int flag)
        {
            double result = 0;
            int begin = 0;
            for (int i = 0; i < function.Length; ++i)
            {
                if ((i == function.Length - 1)&&(flag == 0))
                {
                    int end = function.Length - begin;
                    double sl = 0;
                    if (!double.TryParse(function.Substring(begin, end), out sl))
                    {
                        if (end == 1) sl = x;
                        else sl = parseFunction(function.Substring(begin, end), x, 2);
                    }
                    switch (function.Substring(begin - 1, 1))
                    {
                        case "+": result += sl; break;
                        case "-": result += sl; break;
                    }
                    return result;
                }
                switch(function.Substring(i, 1))
                {
                    case "+":
                    {
                        if (flag != 0) break;
                        int end = i - begin;
                        double sl = 0;
                        if (!double.TryParse(function.Substring(begin, end), out sl))
                        {
                            if (end == 1) sl = x;
                            else sl = parseFunction(function.Substring(begin, end), x, 1);
                        }
                        result += sl;
                        begin = i + 1;
                        i++;
                    }  continue;
                    case "-":
                    {
                        if (flag != 0) break;
                        int end = i - begin;
                        double sl = 0;
                        if (!double.TryParse(function.Substring(begin, end), out sl))
                        {
                            if (end == 1) sl = x;
                            else sl = parseFunction(function.Substring(begin, end), x, 1);
                        }
                        result -= sl;
                        begin = i + 1;
                        i++;
                    } continue;
                    case "^":
                    {
                        if (flag != 2) break;
                        int end = i - begin;
                        double a = 0, b = 0;
                        if (!double.TryParse(function.Substring(begin, end), out a))
                        {
                            if (end == 1) a = x;
                            else a = parseFunction(function.Substring(begin, end), x, 2);
                        }
                        begin = i + 1;
                        end = function.Length - begin;
                        if (!double.TryParse(function.Substring(begin, end), out b))
                        {
                            if (end == 1) b = x;
                            else b = parseFunction(function.Substring(begin, end), x, 2);
                        }
                        result += Math.Pow(a, b);
                    } break;
                    case "*":
                    {
                        if (flag != 1) break;
                        int end = i - begin;
                        double mn1 = 0, mn2 = 0;
                        if (!double.TryParse(function.Substring(begin, end), out mn1))
                        {
                            if (end == 1) mn1 = x;
                            else mn1 = parseFunction(function.Substring(begin, end), x, 2);
                        }
                        begin = i + 1;
                        end = function.Length - begin;
                        if (!double.TryParse(function.Substring(begin, end), out mn2))
                        {
                            if (end == 1) mn2 = x;
                            else mn2 = parseFunction(function.Substring(begin, end), x, 2);
                        }
                        result += mn1 * mn2;
                    } break;
                    case "/":
                    {
                        if (flag != 1) break;
                        int end = i - begin;
                        double mn1 = 0, mn2 = 0;
                        if (!double.TryParse(function.Substring(begin, end), out mn1))
                        {
                            if (end == 1) mn1 = x;
                            else mn1 = parseFunction(function.Substring(begin, end), x, 2);
                        }
                        begin = i + 1;
                        end = function.Length - begin;
                        if (!double.TryParse(function.Substring(begin, end), out mn2))
                        {
                            if (end == 1) mn2 = x;
                            else mn2 = parseFunction(function.Substring(begin, end), x, 2);
                        }
                        result += mn1 / mn2;
                    } break;
                    default: continue;
                }
            }
            return result;
        }
    }
}
