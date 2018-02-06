using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquarFigure
{
    class Statistic
    {
        [Key]
        public int id { get; set; }
        public double delta { get; set; }
        public double x1 { get; set; }
        public double x2 { get; set; }
        public string func { get; set; }
        public double result { get; set; }
    }
}
