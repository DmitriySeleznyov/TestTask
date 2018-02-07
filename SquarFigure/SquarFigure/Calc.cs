using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarFigure
{
    class Calc
    {
        static object locker = new object();
        public async static Task<string> Calculate(double x1, double x2, double round, string func, double part)
        {
                double a = x1;
                double b = x2;

                double result = 0;
                int delta = Delta(round);

                double n = part;
                double h = (b - a) / n;

                DataBase d = new DataBase();
                var countSteps = b / Environment.ProcessorCount;
                b = h + a;
                Task[] tasks = new Task[(int)countSteps - 1];
            var dict = new Dictionary<int, ModelStep>();
            for (int i = 0; i < (int)countSteps - 1; i++)
            {
                
                //if (i == (int)countSteps - 1)
                //{
                //    b -= h;
                //}
                dict.Add(i, new ModelStep
                {
                    a = a,
                    b = b
                });
                a = b;

                b += h;
            }

            for (int j = 0; j < (int)countSteps-1; j++)
                {
                    tasks[j] = Task.Run(() =>
                    {
                            
                        var local1 = dict[j].a;
                            var local2 = dict[j].b;
                        
                        for (double i = local1; i < local2; i += h)
                        {
                            
                            //if (!(await d.CheckData(round, i, i + h, func)))
                            {
                                if (func == "sin(x+5)")
                                { result += Math.Abs((Math.Sin(i + 5)));
                            }
                                if (func == "cos(2*x)")
                                { result += Math.Abs(Math.Cos(2 * i)); }
                                if (func == "sqrt(6-x)")
                                { result += Math.Sqrt(Math.Abs(6 - i));
                            }

                                // d.AddDB(round, i, i + h, func, Math.Round(result, delta));
                            }
                            //else
                            //{
                            //    result += d.ReturnData(round, i, i + h, func);
                            //}
                        }

                    });
                await Task.Delay(10);


                }
                try
                {
                    await Task.WhenAll(tasks);
                    result *= h;
                }
                catch(Exception ex)
                {
                    var kkk = ex;
                }
                

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
