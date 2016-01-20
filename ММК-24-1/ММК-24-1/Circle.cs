using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteKarlo
{
    public class Circle
    {
        float r;
        public float Sq;
        private PointF centr;
        public float Square()
        {
            return (float)(Math.PI * this.r * this.r);
        }
        public Circle()
        {

        }
        public Circle(PointF a, PointF b)
        {
            r = (b.Y - a.Y) / 2;
            centr = new PointF(a.X, a.Y + r);
        }
        public Circle(float ru)
        {
            if (ru > 0)
            {
                this.r = ru;
                this.Sq = Square();
            }
            else throw new ArgumentException();
        }
        public bool IsInCircle(PointF e)
        {
            return (e.X < centr.X) ? ((Math.Pow(e.X - centr.X, 2) + Math.Pow(e.Y - centr.Y, 2)) <= Math.Pow(r, 2)) : false;
        }

        public float minX
        {
            get
            {
                return centr.X - r;
            }
        }

        public PointF centrPoint
        {
            get
            {
                return centr;
            }
        }
    }
}
