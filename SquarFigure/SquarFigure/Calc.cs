using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarFigure
{
    class Calc
    {
        public static string Calculate(double x1, double x2, double round, string func, double part)
        {
            double a = x1;
            double b = x2;

            double result = 0;
            int delta = Delta(round);

            double n = part;
            double h = (b - a) / n;

            DataBase d = new DataBase();

            for (double i = a; i <= b - h; i += h)
            {
                if (!(d.CheckData(round, i, i + h, func)))
                {
                    if (func == "sin(x+5)")
                    { result += Math.Abs((Math.Sin(i + 5))); }
                    if (func == "cos(2*x)")
                    { result += Math.Abs(Math.Cos(2 * i)); }
                    if (func == "sqrt(6-x)")
                    { result += Math.Sqrt(Math.Abs(6 - i)); }

                    d.AddDB(round, i, i + h, func, Math.Round(result, delta));
                }
                else
                {
                    result+=d.RemoveData(round, i, i + h, func);
                }
            }
            result *= h;

            return Math.Round(result, delta).ToString();

        }

        private static int Delta(double round)
        {
            int count = 0;
            while (round != 1)
            {
                round *= 10;
                count++;
            }
            return count;
        }
    }
}
