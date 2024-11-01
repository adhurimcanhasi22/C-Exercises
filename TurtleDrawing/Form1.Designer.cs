namespace TurtleDrawing
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
			buttonDraw = new Button();
			buttonReset = new Button();
			buttonShowHideTurtle = new Button();
			buttonSun = new Button();
			buttonSpiral = new Button();
			buttonStar = new Button();
			buttonHexagon = new Button();
			SuspendLayout();
			// 
			// buttonDraw
			// 
			buttonDraw.Location = new Point(22, 26);
			buttonDraw.Name = "buttonDraw";
			buttonDraw.Size = new Size(94, 41);
			buttonDraw.TabIndex = 0;
			buttonDraw.Text = "Draw";
			buttonDraw.UseVisualStyleBackColor = true;
			buttonDraw.Click += buttonDraw_Click;
			// 
			// buttonReset
			// 
			buttonReset.Location = new Point(22, 91);
			buttonReset.Name = "buttonReset";
			buttonReset.Size = new Size(94, 41);
			buttonReset.TabIndex = 1;
			buttonReset.Text = "Reset";
			buttonReset.UseVisualStyleBackColor = true;
			buttonReset.ClientSizeChanged += buttonReset_Click;
			buttonReset.Click += buttonReset_Click;
			// 
			// buttonShowHideTurtle
			// 
			buttonShowHideTurtle.Location = new Point(22, 138);
			buttonShowHideTurtle.Name = "buttonShowHideTurtle";
			buttonShowHideTurtle.Size = new Size(94, 48);
			buttonShowHideTurtle.TabIndex = 2;
			buttonShowHideTurtle.Text = "Hide Turtle";
			buttonShowHideTurtle.UseVisualStyleBackColor = true;
			buttonShowHideTurtle.Click += buttonShowHideTurtle_Click;
			// 
			// buttonSun
			// 
			buttonSun.Location = new Point(22, 372);
			buttonSun.Name = "buttonSun";
			buttonSun.Size = new Size(94, 34);
			buttonSun.TabIndex = 3;
			buttonSun.Text = "Sun";
			buttonSun.UseVisualStyleBackColor = true;
			buttonSun.Click += buttonSun_Click;
			// 
			// buttonSpiral
			// 
			buttonSpiral.Location = new Point(22, 309);
			buttonSpiral.Name = "buttonSpiral";
			buttonSpiral.Size = new Size(94, 39);
			buttonSpiral.TabIndex = 4;
			buttonSpiral.Text = "Spiral";
			buttonSpiral.UseVisualStyleBackColor = true;
			buttonSpiral.Click += buttonSpiral_Click;
			// 
			// buttonStar
			// 
			buttonStar.Location = new Point(22, 251);
			buttonStar.Name = "buttonStar";
			buttonStar.Size = new Size(94, 39);
			buttonStar.TabIndex = 5;
			buttonStar.Text = "Star";
			buttonStar.UseVisualStyleBackColor = true;
			buttonStar.Click += buttonStar_Click;
			// 
			// buttonHexagon
			// 
			buttonHexagon.Location = new Point(22, 192);
			buttonHexagon.Name = "buttonHexagon";
			buttonHexagon.Size = new Size(94, 42);
			buttonHexagon.TabIndex = 6;
			buttonHexagon.Text = "Hexagon";
			buttonHexagon.UseVisualStyleBackColor = true;
			buttonHexagon.Click += buttonHexagon_Click;
			// 
			// Form1
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(938, 532);
			Controls.Add(buttonHexagon);
			Controls.Add(buttonStar);
			Controls.Add(buttonSpiral);
			Controls.Add(buttonSun);
			Controls.Add(buttonShowHideTurtle);
			Controls.Add(buttonReset);
			Controls.Add(buttonDraw);
			Name = "Form1";
			Text = "Form1";
			ResumeLayout(false);
		}

		#endregion

		private Button buttonDraw;
		private Button buttonReset;
		private Button buttonShowHideTurtle;
		private Button buttonSun;
		private Button buttonSpiral;
		private Button buttonStar;
		private Button buttonHexagon;
	}
}