namespace CurrencyConverter
{
	public partial class FormConverter : Form
	{
		public FormConverter()
		{
			InitializeComponent();
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			ConvertCurrency();
		}

		private void numericUpDownAmount_ValueChanged(object sender, EventArgs e)
		{
			ConvertCurrency();
		}
		private void ConvertCurrency()
		{
			decimal number = this.numericUpDownAmount.Value;
			string currency = this.comboBoxCurrency.SelectedItem.ToString();
			decimal convertedamount = number;
			if (currency == "EUR")
				convertedamount = number / 1.95583m;
			else if (currency == "USD")
				convertedamount = number / 1.80810m;
			else if (currency == "GBP")
				convertedamount = number / 2.54990m;
			this.labelResult.Text = number + "BGN -> " + convertedamount + " " + currency;
		}

		private void FormConverter_Load(object sender, EventArgs e)
		{
			this.comboBoxCurrency.SelectedItem = "EUR";
		}
	}
}