namespace WinFormsApp1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        private void InitializeComponent()
        {
            Increment = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // Increment
            // 
            Increment.Location = new Point(304, 230);
            Increment.Name = "Increment";
            Increment.Size = new Size(124, 40);
            Increment.TabIndex = 0;
            Increment.Text = "Increment";
            Increment.UseVisualStyleBackColor = true;
            Increment.Click += Increment_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 181);
            label1.Name = "label1";
            label1.Size = new Size(17, 20);
            label1.TabIndex = 1;
            label1.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(Increment);
            Name = "Form1";
            Text = "Counter App";
            ResumeLayout(false);
            PerformLayout();
        }
        #endregion

        private Button Increment;
        private Label label1;
    }
}
