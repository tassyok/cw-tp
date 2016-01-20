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
        PointF D;
        PointF C;
        public float Sq;
        public Rectangle(PointF d, PointF c, float r)
        {
            this.C = c;
            this.D = d;
            this.R = r;
            this.Sq = Square();
        }
        public Rectangle()
        {

        }
        float Square()
        {
            return (D.X + R - C.X) * C.Y;
        }
    }
}
