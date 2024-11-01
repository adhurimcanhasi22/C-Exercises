using Nakov.TurtleGraphics;
namespace TurtleDrawing
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void buttonDraw_Click(object sender, EventArgs e)
		{
			Turtle.Delay = 200;

			Turtle.Rotate(30);
			Turtle.Forward(200);
			Turtle.Rotate(120);
			Turtle.Forward(200);
			Turtle.Rotate(120);
			Turtle.Forward(200);

			Turtle.Rotate(-30);
			Turtle.PenUp();
			Turtle.Backward(50);
			Turtle.PenDown();
			Turtle.Backward(100);
			Turtle.PenUp();
			Turtle.Forward(150);
			Turtle.PenDown();
			Turtle.Rotate(30);

		}

		private void buttonReset_Click(object sender, EventArgs e)
		{
			Turtle.Reset();
		}

		private void buttonShowHideTurtle_Click(object sender, EventArgs e)
		{
			if (Turtle.ShowTurtle)
			{
				Turtle.ShowTurtle = false;
				this.buttonShowHideTurtle.Text = "Show Turtle";
			}
			else
			{
				Turtle.ShowTurtle = true;
				this.buttonShowHideTurtle.Text = "Hide Turtle";


			}
		}
		private void buttonHexagon_Click(object sender, EventArgs e)
		{
			Turtle.PenColor = Color.DarkRed;
			Turtle.Delay = 200;

			Turtle.Forward(100);
			Turtle.Rotate(60);
			Turtle.Forward(100);
			Turtle.Rotate(60);
			Turtle.Forward(100);
			Turtle.Rotate(60);
			Turtle.Forward(100);
			Turtle.Rotate(60);
			Turtle.Forward(100);
			Turtle.Rotate(60);
			Turtle.Forward(100);
			Turtle.Rotate(60);
		}

		private void buttonStar_Click(object sender, EventArgs e)
		{
			Turtle.Delay = 200;
			Turtle.PenColor = Color.Gold;

			Turtle.Forward(200);
			Turtle.Rotate(144);
			Turtle.Forward(200);
			Turtle.Rotate(144);
			Turtle.Forward(200);
			Turtle.Rotate(144);
			Turtle.Forward(200);
			Turtle.Rotate(144);
			Turtle.Forward(200);
			Turtle.Rotate(144);
		}

		private void buttonSpiral_Click(object sender, EventArgs e)
		{

			Turtle.Delay = 200;
			Turtle.PenColor = Color.Magenta;



			Turtle.Forward(160);
			Turtle.Rotate(60);
			Turtle.Forward(150);
			Turtle.Rotate(60);
			Turtle.Forward(140);
			Turtle.Rotate(60);
			Turtle.Forward(130);
			Turtle.Rotate(60);
			Turtle.Forward(120);
			Turtle.Rotate(60);
			Turtle.Forward(110);
			Turtle.Rotate(60);
			Turtle.Forward(100);
			Turtle.Rotate(60);
			Turtle.Forward(90);
			Turtle.Rotate(60);
			Turtle.Forward(80);
			Turtle.Rotate(60);
			Turtle.Forward(70);
			Turtle.Rotate(60);
			Turtle.Forward(60);
			Turtle.Rotate(60);
			Turtle.Forward(50);
			Turtle.Rotate(60);
			Turtle.Forward(40);
			Turtle.Rotate(60);
			Turtle.Forward(30);
			Turtle.Rotate(60);
			Turtle.Forward(20);
			Turtle.Rotate(60);

		}

		private void buttonSun_Click(object sender, EventArgs e)
		{

			Turtle.Delay = 50;
			Turtle.PenColor = Color.OrangeRed;
			for (int i = 0; i < 36; i++)
			{
				Turtle.Forward(230);
				Turtle.Rotate(170);
			}

		}
	}
}