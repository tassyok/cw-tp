using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonteKarlo
{
    public class Circle
    {
        float r;
        public float Sq;
        public float Square()
        {
            return (float)(Math.PI * this.r * this.r);
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
    }
}
