namespace CatchMe
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
			buttonCatchMe = new Button();
			SuspendLayout();
			// 
			// buttonCatchMe
			// 
			buttonCatchMe.Location = new Point(174, 109);
			buttonCatchMe.Name = "buttonCatchMe";
			buttonCatchMe.Size = new Size(115, 86);
			buttonCatchMe.TabIndex = 0;
			buttonCatchMe.Text = "button1";
			buttonCatchMe.UseVisualStyleBackColor = true;
			buttonCatchMe.Enter += buttonCatchMe_MouseEnter;
			buttonCatchMe.MouseEnter += buttonCatchMe_MouseEnter;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(481, 301);
			Controls.Add(buttonCatchMe);
			Name = "Form1";
			Text = "CatchMe";
			ResumeLayout(false);
		}

		#endregion

		private Button buttonCatchMe;
	}
}