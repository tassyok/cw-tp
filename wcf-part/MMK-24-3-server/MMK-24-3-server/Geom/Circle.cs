using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MMK_24_3_server.Geom
{
    public class Circle
    {
        float r;
        public float Sq;
        public float Square()
        {
            return (float)(Math.PI * this.r * this.r);
        }
        public Circle(float R)
        {
            if (R > 0)
            {
                this.r = R;
                this.Sq = Square();
            }
            else throw new ArgumentException();
        }
    }
}