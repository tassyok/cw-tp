using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MMK_24_3_server.Geom
{
    public class Triangle
    {
        PointF D;
        PointF C;
        public float Sq;
        public Triangle(PointF d, PointF c)
        {
            this.C = c;
            this.D = d;
            this.Sq = Square();
        }
        public Triangle()
        {

        }

        private float Square()
        {
            return ((D.X - (float)C.X) * C.Y) / 2;
        }
        public float maxX
        {
            get
            {
                return D.X;
            }
        }
        public float minX
        {
            get
            {
                return C.X;
            }
        }

        public float maxY
        {
            get
            {
                return D.Y;
            }
        }

    }
}