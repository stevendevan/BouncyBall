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
        private BallPhysics Physics;
        private bool ResetPhysics;
        private bool mouseDownLeft = false;
        private int radius = 40;
        private int xPrev = 0;
        private int yPrev = 0;
        //private int xCurr = 0;
        //private int yCurr = 0;

        public FormMain()
        {
            InitializeComponent();
            this.timerPhysics.Enabled = true;
        }

        private void FormMain_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDownLeft)
            {
                this.ball.Location = new Point(e.X - (int)(this.radius / 2), e.Y - (int)(this.radius / 2));
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
                //this.timerPhysics.Enabled = true;
                this.mouseDownLeft = true;
                this.ball.Radius = radius;
                this.ball.Width = radius;
                this.ball.Height = radius;
                this.ball.Visible = true;
                this.ball.Location = new Point((int)(e.X - this.ball.Radius) / 2, (int)(e.Y - this.ball.Radius) / 2);
                this.label1.Visible = false;
            }
        }

        private void FormMain_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.label1.Visible = true;
                this.ball.Visible = false;
                //this.timerPhysics.Enabled = false;
            }
        }

        private void TimerPhysics_Tick(object sender, EventArgs e)
        {
            if (mouseDownLeft == true)
            {
                ResetPhysics = true;
                xPrev = MousePosition.X;
                yPrev = MousePosition.Y;
            }

            if (mouseDownLeft == false)
            {
                if (ResetPhysics == true)
                {
                    Physics = new BallPhysics(MousePosition.X, xPrev, MousePosition.Y, yPrev, timerPhysics.Interval * .001f);
                    ResetPhysics = false;
                }
                
                if (Physics != null)
                {
                    this.ball.Location = new Point(Physics.DeltaPositionX() - (this.ball.Radius / 2), Physics.DeltaPositionY() - (this.ball.Radius / 2));
                }
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
