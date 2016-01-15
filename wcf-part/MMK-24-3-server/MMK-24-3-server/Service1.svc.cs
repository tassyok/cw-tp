using System;
using System.Collections.Generic;
using System.Drawing;
using MMK_24_3_server.Geom;

namespace MMK_24_3_server
{
    public class Service1 : IService1
    {
        float r, k, b, delta, square, rectSquare;
        Point C, D;
        Random rnd = new Random();
        private List<double> result;
        private DateTime start, stop;
        public double[] GetData(float r, float k, float b, float delta, float rectSquare, float square, Point C, Point D, int iterations)
        {
            this.r = r;
            this.k = k;
            this.b = b;
            this.delta = delta;
            this.rectSquare = rectSquare;
            this.C = C;
            this.D = D;
            this.square = square;
            return Mmk(iterations);
        }
        

        private double[] Mmk(int iterations)
        {
            result = new List<double>();
            int c = 0;
            double x, y, n = (D.X + r - C.X);
            start = DateTime.Now;
            for (int i = 0; i < iterations; i++)
            {
                x = rnd.NextDouble()*n + C.X;
                y = rnd.NextDouble()*D.Y;
                if (x <= D.X)
                {
                    //если точка попала слева от центра окружности
                    //if (Math.Atan((y - C.Y) / (x - C.X)) >= delta) //строка 1
                    //проверку можно проводить и по коэффициенту, но если нужна проверка строго по углу, то необходимо раскомментировать строку 1 и закомментировать строку 2 (скорость упадёт примерно в 5 раз)
                    {
                        if ((y - C.Y)/(x - C.X) >= k) //строка 2
                        {
                            c++;
                        }
                    }
                }
                else
                {
                    //точка попала справа от центра окружности ==> нужно вычислять, факт принадлежности точки окружности
                    if (Math.Pow(y - (C.Y - r), 2) + Math.Pow(x - D.X, 2) <= Math.Pow(r, 2))
                    {
                        c++;
                    }
                }
            }
            stop = DateTime.Now;
            result.Add(c);
            result.Add(((double) c/iterations)*rectSquare);
            result.Add(((int) ((stop - start).TotalMilliseconds)));
            if (square < ((double) c/iterations)*rectSquare)
                result.Add((((double) c/iterations)*rectSquare)/square*100 - 100);
            else result.Add(square/(((double) c/iterations)*rectSquare)*100 - 100);
            return result.ToArray();
        }

        public float GetRealSquare(Point C,Point D)
        {
            var realSquare = 0.0f;
            float r = (float)C.Y / 2;
            Geom.Rectangle rectangle = new Geom.Rectangle(D, C, r);
            Circle circle = new Circle(r);
            Triangle triangle = new Triangle(D, C);
            if (C.Y > 0 && C.X >= 0 && C.X < D.X)
            {
                float k = -C.Y / (D.X - C.X);
                float b = C.Y - k * C.X;
                float delta = (float)Math.Atan(k);
                float rectSquare = rectangle.Sq;
                realSquare = triangle.Sq + (circle.Sq / 2);
            }
                return realSquare;
        }

        public float[] GetSomeData(Point C, Point D)
        {
            return C.Y > 0 && C.X >= 0 && C.X < D.X ?
                new float[] { -C.Y / (D.X - C.X),
                               C.Y - k * C.X,
                               (float)Math.Atan(k),
                               (new Geom.Rectangle(D,C, ((float)C.Y/2))).Sq,
                               GetRealSquare(C,D)
                } :null;
        }
    }
}
