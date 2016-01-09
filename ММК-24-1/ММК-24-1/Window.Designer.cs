namespace MonteKarlo
{
    partial class Window
    {
        /// <summary>
        /// Требуется переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Обязательный метод для поддержки конструктора - не изменяйте
        /// содержимое данного метода при помощи редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.Dx = new System.Windows.Forms.NumericUpDown();
            this.Cy = new System.Windows.Forms.NumericUpDown();
            this.Cx = new System.Windows.Forms.NumericUpDown();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DGV_Iterations = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.Sqr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Hits = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ratio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.RealSquare = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Dx
            // 
            this.Dx.Location = new System.Drawing.Point(282, 179);
            this.Dx.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Dx.Name = "Dx";
            this.Dx.Size = new System.Drawing.Size(86, 20);
            this.Dx.TabIndex = 39;
            // 
            // Cy
            // 
            this.Cy.Location = new System.Drawing.Point(159, 179);
            this.Cy.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Cy.Name = "Cy";
            this.Cy.Size = new System.Drawing.Size(86, 20);
            this.Cy.TabIndex = 37;
            // 
            // Cx
            // 
            this.Cx.Location = new System.Drawing.Point(37, 179);
            this.Cx.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.Cx.Name = "Cx";
            this.Cx.Size = new System.Drawing.Size(86, 20);
            this.Cx.TabIndex = 36;
            // 
            // N
            // 
            this.N.HeaderText = "N";
            this.N.Name = "N";
            this.N.ReadOnly = true;
            this.N.Width = 30;
            // 
            // DGV_Iterations
            // 
            this.DGV_Iterations.HeaderText = "Итераций";
            this.DGV_Iterations.Name = "DGV_Iterations";
            this.DGV_Iterations.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(254, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 35;
            this.label4.Text = "DX";
            // 
            // Sqr
            // 
            this.Sqr.HeaderText = "Площадь";
            this.Sqr.Name = "Sqr";
            this.Sqr.ReadOnly = true;
            // 
            // Time
            // 
            this.Time.HeaderText = "Время";
            this.Time.Name = "Time";
            this.Time.ReadOnly = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.DGV_Iterations,
            this.Hits,
            this.Sqr,
            this.Time,
            this.Ratio});
            this.dataGridView1.Location = new System.Drawing.Point(270, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(574, 150);
            this.dataGridView1.TabIndex = 32;
            // 
            // Hits
            // 
            this.Hits.HeaderText = "Попаданий";
            this.Hits.Name = "Hits";
            this.Hits.ReadOnly = true;
            // 
            // Ratio
            // 
            this.Ratio.HeaderText = "Погрешность, %";
            this.Ratio.MaxInputLength = 9;
            this.Ratio.Name = "Ratio";
            this.Ratio.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 179);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "CX";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(688, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 29;
            this.button1.Text = "Рассчитать";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 139);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            // 
            // RealSquare
            // 
            this.RealSquare.AutoSize = true;
            this.RealSquare.Location = new System.Drawing.Point(487, 184);
            this.RealSquare.Name = "RealSquare";
            this.RealSquare.Size = new System.Drawing.Size(0, 13);
            this.RealSquare.TabIndex = 33;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(131, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 34;
            this.label3.Text = "CY";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 13);
            this.label2.TabIndex = 40;
            this.label2.Text = "Точная площадь:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(769, 178);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 41;
            this.button2.Text = "Очистить";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(557, 179);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(125, 23);
            this.button3.TabIndex = 42;
            this.button3.Text = "Контрольный пример";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 213);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Dx);
            this.Controls.Add(this.Cy);
            this.Controls.Add(this.Cx);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.RealSquare);
            this.Controls.Add(this.label3);
            this.Name = "Window";
            this.Text = "Метод Монте-Карло";
            ((System.ComponentModel.ISupportInitialize)(this.Dx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown Dx;
        private System.Windows.Forms.NumericUpDown Cy;
        private System.Windows.Forms.NumericUpDown Cx;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewTextBoxColumn DGV_Iterations;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sqr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Time;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hits;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ratio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label RealSquare;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;

    }
}

