namespace GradingSys
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            textBox4 = new TextBox();
            Compute = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Cursor = Cursors.Cross;
            textBox1.Location = new Point(39, 38);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(241, 36);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.BorderStyle = BorderStyle.None;
            textBox2.Location = new Point(39, 120);
            textBox2.Multiline = true;
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(241, 36);
            textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.BorderStyle = BorderStyle.None;
            textBox3.Location = new Point(39, 208);
            textBox3.Multiline = true;
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(241, 36);
            textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            textBox4.BorderStyle = BorderStyle.None;
            textBox4.Location = new Point(39, 297);
            textBox4.Multiline = true;
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(241, 36);
            textBox4.TabIndex = 3;
            // 
            // Compute
            // 
            Compute.BackColor = Color.FromArgb(51, 217, 178);
            Compute.FlatAppearance.BorderSize = 0;
            Compute.FlatStyle = FlatStyle.Flat;
            Compute.Location = new Point(106, 421);
            Compute.Name = "Compute";
            Compute.Size = new Size(96, 47);
            Compute.TabIndex = 4;
            Compute.Text = "Compute";
            Compute.UseVisualStyleBackColor = false;
            Compute.Click += Compute_Clicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Cooper Black", 24.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(92, 356);
            label1.Name = "label1";
            label1.Size = new Size(125, 38);
            label1.TabIndex = 5;
            label1.Text = "Result";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.FlatStyle = FlatStyle.Flat;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.Location = new Point(39, 14);
            label2.Name = "label2";
            label2.Size = new Size(37, 19);
            label2.TabIndex = 6;
            label2.Text = "First";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.FlatStyle = FlatStyle.Flat;
            label3.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label3.Location = new Point(39, 96);
            label3.Name = "label3";
            label3.Size = new Size(58, 19);
            label3.TabIndex = 7;
            label3.Text = "Second";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.FlatStyle = FlatStyle.Flat;
            label4.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label4.Location = new Point(39, 184);
            label4.Name = "label4";
            label4.Size = new Size(44, 19);
            label4.TabIndex = 8;
            label4.Text = "Third";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.FlatStyle = FlatStyle.Flat;
            label5.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label5.Location = new Point(39, 273);
            label5.Name = "label5";
            label5.Size = new Size(52, 19);
            label5.TabIndex = 9;
            label5.Text = "Fourth";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(204, 174, 98);
            ClientSize = new Size(333, 489);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Compute);
            Controls.Add(textBox4);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private TextBox textBox4;
        private Button Compute;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
