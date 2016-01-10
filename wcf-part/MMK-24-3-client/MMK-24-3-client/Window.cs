﻿using System;
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
            if (C.Y > 0 && C.X >= 0 && C.X < D.X)
            {
                float k = -C.Y / (D.X - C.X);
                float b = C.Y - k * C.X;
                float delta = (float)Math.Atan(k);
                float rectSquare = (D.X + r - C.X) * C.Y;
                float square = ((D.X - (float)C.X) * C.Y) / 2 + (float)(Math.PI * r * r / 2);
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
                float k = -C.Y / (D.X - C.X);
                float b = C.Y - k * C.X;
                float delta = (float)Math.Atan(k);
                float rectSquare = (D.X + r - C.X) * C.Y;
                float square = ((D.X - (float)C.X) * C.Y) / 2 + (float)(Math.PI * r * r / 2);
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
}
