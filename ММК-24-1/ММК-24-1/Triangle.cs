using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteKarlo
{
    public class Triangle
    {
        Point D;
        Point C;
        public float Sq;
        public Triangle(Point d, Point c)
        {
            this.C = c;
            this.D = d;
            this.Sq = Square();
        }

        private float Square()
        {
            return ((D.X - (float)C.X) * C.Y) / 2;
        }
    }
}
