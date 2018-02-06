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
        private StatisticContext db;

        public void AddDB(double delta, double x1, double x2,string func, double result)
        {
            db = new StatisticContext();
            db.Statistics.Load();

            Statistic stat = new Statistic {delta=delta, x1 = x1, x2 = x2, func = func, result = result };
            
            db.Statistics.Add(stat);
            db.SaveChanges();
        }

        public bool CheckData(double delta, double x1, double x2, string func)
        {
                
            db = new StatisticContext();
            db.Statistics.Load();
            var check = db.Statistics.FirstOrDefault(x => (x.delta == delta) & (x.x1 == x1) & (x.x2 == x2) & (x.func == func));
            if (check == null) return false;
            else return true;
        }

        public double RemoveData(double delta, double x1, double x2, string func)
        {
            var check = db.Statistics.First(x => (x.delta == delta) & (x.x1 == x1) & (x.x2 == x2) & (x.func == func));
            return check.result;
        }
    }
}
