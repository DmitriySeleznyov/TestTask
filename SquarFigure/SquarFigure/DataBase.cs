using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarFigure
{
    class DataBase
    {
        public void AddDB(double delta, double x1, double x2,string func, double result)
        {
            try
            {
                using (var db2 = new StatisticContext())
                {
                     db2.Statistics.LoadAsync();

                    Statistic stat = new Statistic { delta = delta, x1 = x1, x2 = x2, func = func, result = result };

                    db2.Statistics.Add(stat);
                     db2.SaveChangesAsync();
                }

            }
            catch(Exception ex)
            {

            }
        }

        public async Task<bool> CheckData(double delta, double x1, double x2, string func)
        {
            try
            {
                using (var db2 = new StatisticContext())
                {
                    await db2.Statistics.LoadAsync();
                    var list = await db2.Statistics.ToListAsync();
                    try
                    {
                        return list.Any(x => x.delta == delta && x.x1 == x1 && x.x2 == x2 && x.func == func);
                    }
                    catch (Exception)
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public double ReturnData(double delta, double x1, double x2, string func)
        {
            try
            {
                using (var db2 = new StatisticContext())
                {
                    var check = db2.Statistics.FirstOrDefault(x => (x.delta == delta) && (x.x1 == x1) && (x.x2 == x2) && (x.func == func));
                    return check.result;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
        }
    }
}
