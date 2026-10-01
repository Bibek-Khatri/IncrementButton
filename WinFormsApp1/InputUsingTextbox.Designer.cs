namespace WinFormsApp1
{
    partial class InputUsingTextbox
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
            label1 = new Label();
            textBox1 = new TextBox();
            Greet = new Label();
            textBox2 = new TextBox();
            Display = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 133);
            label1.Name = "label1";
            label1.Size = new Size(119, 20);
            label1.TabIndex = 0;
            label1.Text = "Enter you name :";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(348, 130);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(148, 27);
            textBox1.TabIndex = 1;
            // 
            // Greet
            // 
            Greet.AutoSize = true;
            Greet.Location = new Point(254, 231);
            Greet.Name = "Greet";
            Greet.Size = new Size(52, 20);
            Greet.TabIndex = 2;
            Greet.Text = "Greet :";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(330, 228);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(148, 27);
            textBox2.TabIndex = 3;
            // 
            // Display
            // 
            Display.Location = new Point(363, 176);
            Display.Name = "Display";
            Display.Size = new Size(88, 31);
            Display.TabIndex = 5;
            Display.Text = "Display";
            Display.UseVisualStyleBackColor = true;
            Display.Click += Display_Click;
            // 
            // InputUsingTextbox
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Display);
            Controls.Add(textBox2);
            Controls.Add(Greet);
            Controls.Add(textBox1);
            Controls.Add(label1);
            Name = "InputUsingTextbox";
            Text = "InputUsingTextbox";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBox1;
        private Label Greet;
        private TextBox textBox2;
        private Button Display;
    }
}