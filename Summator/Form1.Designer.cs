namespace Summator
{
    partial class FormCalculate
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
            textBoxSum = new TextBox();
            label1 = new Label();
            label2 = new Label();
            buttonCalculate = new Button();
            SuspendLayout();
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(74, 23);
            textBox1.TabIndex = 0;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(122, 13);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(76, 23);
            textBox2.TabIndex = 1;
            // 
            // textBoxSum
            // 
            textBoxSum.Location = new Point(252, 13);
            textBoxSum.Name = "textBoxSum";
            textBoxSum.Size = new Size(100, 23);
            textBoxSum.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(101, 16);
            label1.Name = "label1";
            label1.Size = new Size(15, 15);
            label1.TabIndex = 3;
            label1.Text = "+";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(217, 16);
            label2.Name = "label2";
            label2.Size = new Size(15, 15);
            label2.TabIndex = 4;
            label2.Text = "=";
            // 
            // buttonCalculate
            // 
            buttonCalculate.Location = new Point(58, 57);
            buttonCalculate.Name = "buttonCalculate";
            buttonCalculate.Size = new Size(265, 38);
            buttonCalculate.TabIndex = 5;
            buttonCalculate.Text = "Calculate";
            buttonCalculate.UseVisualStyleBackColor = true;
            buttonCalculate.Click += buttonCalculate_Click;
            // 
            // FormCalculate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(378, 107);
            Controls.Add(buttonCalculate);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBoxSum);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Name = "FormCalculate";
            Text = "Summator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBoxSum;
        private Label label1;
        private Label label2;
        private Button buttonCalculate;
    }
}