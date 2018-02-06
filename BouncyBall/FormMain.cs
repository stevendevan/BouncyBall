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
        private int radius = 40;

        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownLeft)
            {
                ball.Location = new Point(e.Location.X - (int)(this.radius / 2), e.Location.Y - (int)(this.radius / 2));
                //ball.Update(); //not sure if this is needed. Invalidate() causes flickering
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
                this.mouseDownLeft = false;
            }
        }

        private void FormMain_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.mouseDownLeft = true;
                this.ball.Radius = radius;
                this.ball.Width = radius;
                this.ball.Height = radius;
                this.ball.Visible = true;
                this.ball.Location = new Point((int)(this.Width - this.label1.Width) / 2, (int)(this.Height - this.label1.Height) / 2);
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
                this.ball.Visible = false;
            }
        }

        private void TimerPhysics_Tick(object sender, EventArgs e)
        {
            if (mouseDownLeft == false)
            {
                this.ball.Location = new Point(50,50);
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
