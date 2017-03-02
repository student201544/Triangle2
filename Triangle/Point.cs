using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Point
    {
        public double x { get; set; }
        public double y { get; set; }

        // constructor

        public Point(int j, int i) //объекты класса Point имеют две координаты
        {
            x = j;
            y = i;
        }
    }
}
