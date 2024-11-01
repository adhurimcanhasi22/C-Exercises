namespace CurrencyConverter
{
	partial class FormConverter
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
			numericUpDownAmount = new NumericUpDown();
			comboBoxCurrency = new ComboBox();
			labelResult = new Label();
			label2 = new Label();
			((System.ComponentModel.ISupportInitialize)numericUpDownAmount).BeginInit();
			SuspendLayout();
			// 
			// numericUpDownAmount
			// 
			numericUpDownAmount.DecimalPlaces = 2;
			numericUpDownAmount.Location = new Point(174, 85);
			numericUpDownAmount.Margin = new Padding(4);
			numericUpDownAmount.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
			numericUpDownAmount.Name = "numericUpDownAmount";
			numericUpDownAmount.Size = new Size(154, 29);
			numericUpDownAmount.TabIndex = 0;
			numericUpDownAmount.TextAlign = HorizontalAlignment.Right;
			numericUpDownAmount.Value = new decimal(new int[] { 1, 0, 0, 0 });
			numericUpDownAmount.ValueChanged += numericUpDownAmount_ValueChanged;
			// 
			// comboBoxCurrency
			// 
			comboBoxCurrency.DropDownStyle = ComboBoxStyle.DropDownList;
			comboBoxCurrency.FormattingEnabled = true;
			comboBoxCurrency.Items.AddRange(new object[] { "EUR", "USD", "GBP" });
			comboBoxCurrency.Location = new Point(534, 85);
			comboBoxCurrency.Margin = new Padding(4);
			comboBoxCurrency.Name = "comboBoxCurrency";
			comboBoxCurrency.Size = new Size(154, 29);
			comboBoxCurrency.TabIndex = 1;
			comboBoxCurrency.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
			// 
			// labelResult
			// 
			labelResult.BackColor = Color.PaleGreen;
			labelResult.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
			labelResult.Location = new Point(239, 156);
			labelResult.Margin = new Padding(4, 0, 4, 0);
			labelResult.Name = "labelResult";
			labelResult.Size = new Size(396, 49);
			labelResult.TabIndex = 2;
			labelResult.TextAlign = ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(400, 90);
			label2.Margin = new Padding(4, 0, 4, 0);
			label2.Name = "label2";
			label2.Size = new Size(52, 21);
			label2.TabIndex = 3;
			label2.Text = "label2";
			// 
			// FormConverter
			// 
			AutoScaleDimensions = new SizeF(9F, 21F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(861, 241);
			Controls.Add(label2);
			Controls.Add(labelResult);
			Controls.Add(comboBoxCurrency);
			Controls.Add(numericUpDownAmount);
			Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Margin = new Padding(4);
			MaximizeBox = false;
			MinimizeBox = false;
			Name = "FormConverter";
			Text = "Currency Converter";
			Load += FormConverter_Load;
			((System.ComponentModel.ISupportInitialize)numericUpDownAmount).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private NumericUpDown numericUpDownAmount;
		private ComboBox comboBoxCurrency;
		private Label labelResult;
		private Label label2;
	}
}