using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyBall
{
    public partial class FormMain : Form
    {
        //private Ball ball = new Ball();
        bool mouseDownLeft = false;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownLeft)
            {
                ball1.Location = new Point(e.Location.X, e.Location.Y);
                //ball1.Invalidate();
            }
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            this.label1.Location = new Point((int)(this.Width - this.label1.Width) / 2, (int)(this.Height - this.label1.Height) / 2);
        }

        private void FormMain_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLeft = false;
            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                mouseDownLeft = true;
                ball1.Location = new Point(e.Location.X, e.Location.Y);
                //ball.Visible = true;
                //ball.Location = new Point(e.Location.X, e.Location.Y);
                //ball.Invalidate();
                this.label1.Visible = false;
            }
        }

        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.label1.Visible = true;
            }
        }

        private void timerPhysics_Tick(object sender, EventArgs e)
        {
            if (mouseDownLeft == false)
            {
                // run physics calcs and invalidate ball
            }
        }

        //private void Form1_MouseClick(object sender, MouseEventArgs e)
        //{
        //    if (e.Button == MouseButtons.Left)
        //    {
        //        this.textBox1.Visible = false;
        //    }
        //}
    }
}
