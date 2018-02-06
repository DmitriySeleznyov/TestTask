using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarFigure
{
    class StatisticContext : DbContext
    {
        public StatisticContext()
            :base("StatisticContext")
        { }
        
        public DbSet<Statistic> Statistics { get; set; }
    }
}
