using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteKarlo
{
    public class Rectangle
    {
        float R;
        Point D;
        Point C;
        public float Sq;
        public Rectangle(Point d, Point c, float r)
        {
            this.C = c;
            this.D = d;
            this.R = r;
            this.Sq = Square();
        }
        float Square()
        {
            return (D.X + R - C.X) * C.Y;
        }
    }
}
