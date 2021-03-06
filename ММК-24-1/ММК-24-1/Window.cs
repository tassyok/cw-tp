﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonteKarlo
{
    public partial class Window : Form
    {
        float r, k, b, angle, realSquare, rectSquare;
        PointF C, D;
        public Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            C = new PointF((int)Cx.Value, (int)Cy.Value);
            D = new PointF((int)Dx.Value, (int)Cy.Value);
            r = (float)C.Y / 2;
            Rectangle rectangle = new Rectangle(D,C,r);
            Circle circle = new Circle(r);
            Triangle triangle = new Triangle(D, C);
            if (C.Y > 0 && C.X >= 0 && C.X < D.X)
            {
                k = -C.Y / (D.X - C.X);
                b = C.Y - k * C.X;
                angle = (float)Math.Atan(k);
                rectSquare = rectangle.Sq;
                realSquare = triangle.Sq  + (circle.Sq/ 2);
                RealSquare.Text = realSquare.ToString();
                StartMonteKarlo();
            }
            else
            {
                MessageBox.Show("Некорректные данные!");
            }
        }

        private void StartMonteKarlo()
        {
            dataGridView1.Rows.Clear();
            for (int i = 3; i < 8; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[0].Value = (i - 2).ToString();
                dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[1].Value = ((int)Math.Pow(10.0, i)).ToString();
                MonteKarlo((int)Math.Pow(10.0, i));
            }
        }

        private void MonteKarlo(int iterations)
        {

            int c = 0;
            double x, y, n = (D.X + r - C.X);
            Random rnd = new Random();
            DateTime start = DateTime.Now;
            for (int i = 0; i < iterations; i++)
            {
                x = rnd.NextDouble() * (D.X + r - C.X) + C.X;
                y = rnd.NextDouble() * D.Y;
                if (x <= D.X)
                {
                    //если точка попала слева от центра окружности
                    if (Math.Atan((y - C.Y) / (x - C.X)) >= angle) //строка 1
                    //проверку можно проводить и по коэффициенту, но если нужна проверка строго по углу, то необходимо раскомментировать строку 1 и закомментировать строку 2 (скорость упадёт примерно в 5 раз)
                    {
                        // if ((y - C.Y)/(x - C.X) >= k) //строка 2
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
            DateTime stop = DateTime.Now;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[2].Value = c.ToString();
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[3].Value = ((double)c / iterations) * rectSquare;
            dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[4].Value = ((int)((stop - start).TotalMilliseconds)).ToString();
            if (realSquare < ((double)c / iterations) * rectSquare) dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = (((double)c / iterations) * rectSquare) / realSquare * 100 - 100;
            else dataGridView1.Rows[dataGridView1.Rows.Count - 1].Cells[5].Value = realSquare / (((double)c / iterations) * rectSquare) * 100 - 100;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RealSquare.Text = null;
            dataGridView1.Rows.Clear();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            this.Dx.Value = 4;
            this.Cx.Value = 3;
            this.Cy.Value = 7; 
            C = new PointF((int)Cx.Value, (int)Cy.Value);
            D = new PointF((int)Dx.Value, (int)Cy.Value);
            r = (float)C.Y / 2;
            k = -C.Y / (D.X - C.X);
            b = C.Y - k * C.X;
            Rectangle rectangle = new Rectangle(D, C, r);
            Circle circle = new Circle(r);
            Triangle triangle = new Triangle(D, C);
            angle = (float)Math.Atan(k);
            rectSquare = rectangle.Sq;
            realSquare = triangle.Sq + (circle.Sq / 2);
            RealSquare.Text = realSquare.ToString();
            StartMonteKarlo();
            
        }
    }
}
