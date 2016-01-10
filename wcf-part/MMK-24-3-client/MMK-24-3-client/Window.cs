using System;
using System.Drawing;
using System.Windows.Forms;
using MMK_24_3_client.ServiceReference1;

namespace MMK_24_3_client
{
    public partial class Window : Form
    {
        public Window()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();

            Service1Client Client = new Service1Client();
            Point C = new Point((int)Cx.Value, (int)Cy.Value);
            Point D = new Point((int)Dx.Value, (int)Cy.Value);
            float r = (float)C.Y / 2;
            Rectangle rectangle = new Rectangle(D, C, r);
            Circle circle = new Circle(r);
            Triangle triangle = new Triangle(D, C);

            if (C.Y > 0 && C.X >= 0 && C.X < D.X)
            {
                float k = -C.Y / (D.X - C.X);
                float b = C.Y - k * C.X;
                float delta = (float)Math.Atan(k);
                float rectSquare = rectangle.Sq;
                float square = triangle.Sq + (circle.Sq / 2); 
                RealSquare.Text = square.ToString();
                for (int i = 0; i < 5; i++)
                {
                    double[] result = Client.GetData(r, k, b, delta, rectSquare, square, C, D, (int)Math.Pow(10, i + 3));
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.Rows[i].Cells[1].Value = (int)Math.Pow(10, i + 3);
                    dataGridView1.Rows[i].Cells[2].Value = result[0];
                    dataGridView1.Rows[i].Cells[3].Value = result[1];
                    dataGridView1.Rows[i].Cells[4].Value = result[2];
                    dataGridView1.Rows[i].Cells[5].Value = result[3];
                }
            }
            else
            {
                MessageBox.Show("Некорректные данные!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RealSquare.Text = null;
            dataGridView1.Rows.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Cx.Value = 3;
            this.Cy.Value = 7;
            this.Dx.Value = 4;
            //dataGridView1.Rows.Clear();
            Service1Client Client = new Service1Client();
            Point C = new Point((int)Cx.Value, (int)Cy.Value);
            Point D = new Point((int)Dx.Value, (int)Cy.Value);
            float r = (float)C.Y / 2;
            Rectangle rectangle = new Rectangle(D, C, r);
            Circle circle = new Circle(r);
            Triangle triangle = new Triangle(D, C);

                float k = -C.Y / (D.X - C.X);
                float b = C.Y - k * C.X;
                float delta = (float)Math.Atan(k);
                float rectSquare = rectangle.Sq;
                float square = triangle.Sq + (circle.Sq / 2);
                RealSquare.Text = square.ToString();
                for (int i = 0; i < 5; i++)
                {
                    double[] result = Client.GetData(r, k, b, delta, rectSquare, square, C, D, (int)Math.Pow(10, i + 3));
                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = i + 1;
                    dataGridView1.Rows[i].Cells[1].Value = (int)Math.Pow(10, i + 3);
                    dataGridView1.Rows[i].Cells[2].Value = result[0];
                    dataGridView1.Rows[i].Cells[3].Value = result[1];
                    dataGridView1.Rows[i].Cells[4].Value = result[2];
                    dataGridView1.Rows[i].Cells[5].Value = result[3];
                }
        }
    }

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


