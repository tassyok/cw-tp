using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;

namespace MMK_24_3_server.Geom
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