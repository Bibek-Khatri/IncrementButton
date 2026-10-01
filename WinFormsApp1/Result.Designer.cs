namespace WinFormsApp1
{
    partial class StudentResult
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Math = new Label();
            Science = new Label();
            label3 = new Label();
            Total = new Label();
            Result = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Math
            // 
            Math.AutoSize = true;
            Math.Location = new Point(212, 128);
            Math.Name = "Math";
            Math.Size = new Size(43, 20);
            Math.TabIndex = 0;
            Math.Text = "Math";
            // 
            // Science
            // 
            Science.AutoSize = true;
            Science.Location = new Point(212, 180);
            Science.Name = "Science";
            Science.Size = new Size(59, 20);
            Science.TabIndex = 1;
            Science.Text = "Science";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(212, 235);
            label3.Name = "label3";
            label3.Size = new Size(75, 20);
            label3.TabIndex = 2;
            label3.Text = "Computer";
            // 
            // Total
            // 
            Total.AutoSize = true;
            Total.Location = new Point(212, 304);
            Total.Name = "Total";
            Total.Size = new Size(49, 20);
            Total.TabIndex = 3;
            Total.Text = "Total :";
            // 
            // Result
            // 
            Result.AutoSize = true;
            Result.Location = new Point(212, 350);
            Result.Name = "Result";
            Result.Size = new Size(56, 20);
            Result.TabIndex = 4;
            Result.Text = "Result :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(288, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(140, 27);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(288, 180);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(140, 27);
            textBox2.TabIndex = 6;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(293, 235);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(140, 27);
            textBox3.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(276, 304);
            label1.Name = "label1";
            label1.Size = new Size(50, 20);
            label1.TabIndex = 8;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(274, 350);
            label2.Name = "label2";
            label2.Size = new Size(50, 20);
            label2.TabIndex = 9;
            label2.Text = "label2";
            // 
            // StudentResult
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(Result);
            Controls.Add(Total);
            Controls.Add(label3);
            Controls.Add(Science);
            Controls.Add(Math);
            Name = "StudentResult";
            Text = "Result";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Math;
        private Label Science;
        private Label label3;
        private Label Total;
        private Label Result;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
    }
}