using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangle
{
    public class Triangle
    {
        public Point c { get; set; }
        public Point d { get; set; }
        public Point e { get; set; }

        public Triangle(Point point0, Point point1, Point point2) //объекты класса Triangle состоят из трех объектов класса Point
        {

            if ((point2.x - point0.x) * (point1.y - point0.y) == (point1.x - point0.x) * (point2.y - point0.y)) // лежат ли точки на одной прямой?
            {
                c = null;
                d = null;
                e = null;
            }
            else
            {
                c = point0;
                d = point1;
                e = point2;
            }
        }

        public double Perimetr() //периметр
        {

            double perim = Edge.lengthEdge(c, d) + Edge.lengthEdge(c, e) + Edge.lengthEdge(d, e);

            return perim;
        }
        public double Area()  //площадь
        {

            double p = this.Perimetr() / 2;

            double ar = Math.Sqrt(p * (p - Edge.lengthEdge(c, d)) * (p - Edge.lengthEdge(c, e)) * (p - Edge.lengthEdge(d, e)));

            return ar;
        }

        public bool Right() // прямоугольный треугольник?    (a^2 + b^2 = f^2)
        {
            double a = Math.Round(Math.Pow(Edge.lengthEdge(c, d), 2));
            double b = Math.Round(Math.Pow(Edge.lengthEdge(c, e), 2));
            double f = Math.Round(Math.Pow(Edge.lengthEdge(d, e), 2));



            if ((a == (b + f)) || (b == (a + f)) || (f == (a + b)))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool Isosceles()   //равнобедренные треугольник?
        {
            double a = Edge.lengthEdge(c, d);
            double b = Edge.lengthEdge(c, e);
            double f = Edge.lengthEdge(d, e);

            if ((a == b) || (b == f) || (f == a))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
