using System;
using Nakov.TurtleGraphics;
using System.Windows.Forms;

namespace Turtle_Graphics
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            Turtle.Delay = 100;
            Turtle.Rotate(30);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(120);
            Turtle.Forward(200);
            Turtle.Rotate(-30);
            Turtle.PenUp();
            Turtle.Backward(30);
            Turtle.PenDown();
            Turtle.Backward(100);
            Turtle.PenUp();
            Turtle.Forward(130);
            Turtle.PenDown();
        }

        private void buttonReset_Click(object sender, EventArgs e)
        {
            Turtle.Reset();
        }

        private void buttonHideTurtle_Click(object sender, EventArgs e)
        {
            if (Turtle.ShowTurtle)
            {
                Turtle.ShowTurtle=false;
                this.buttonHideTurtle.Text = "Show Turtel";
            }
            else
            {
                Turtle.ShowTurtle = true;
                this.buttonHideTurtle.Text = "Hide Turtel";
            }
        }
    }
}
