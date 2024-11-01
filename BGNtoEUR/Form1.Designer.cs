namespace BGNtoEUR
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
			label1 = new Label();
			label2 = new Label();
			labelResult = new Label();
			numericUpDownAmount = new NumericUpDown();
			((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(34, 48);
			label1.Name = "label1";
			label1.Size = new Size(59, 15);
			label1.TabIndex = 0;
			label1.Text = "Converter";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(273, 48);
			label2.Name = "label2";
			label2.Size = new Size(69, 15);
			label2.TabIndex = 1;
			label2.Text = "BGN to EUR";
			// 
			// labelResult
			// 
			labelResult.AutoSize = true;
			labelResult.Location = new Point(168, 102);
			labelResult.Name = "labelResult";
			labelResult.Size = new Size(0, 15);
			labelResult.TabIndex = 2;
			// 
			// numericUpDownAmount
			// 
			numericUpDownAmount.DecimalPlaces = 2;
			numericUpDownAmount.Location = new Point(114, 46);
			numericUpDownAmount.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
			numericUpDownAmount.Name = "numericUpDownAmount";
			numericUpDownAmount.Size = new Size(120, 23);
			numericUpDownAmount.TabIndex = 3;
			numericUpDownAmount.TextAlign = HorizontalAlignment.Right;
			numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownAmount.ValueChanged += numericUpDownAmount_ValueChanged;
			numericUpDownAmount.KeyUp += numericUpDownAmount_KeyUp;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(numericUpDownAmount);
			Controls.Add(labelResult);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "Form1";
			Text = "Form1";
			Load += Form1_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label labelResult;
		private NumericUpDown numericUpDownAmount;
	}
}