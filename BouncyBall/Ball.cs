using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace BouncyBall
{
    class Ball : Control // sealed?
    {
        private int radius = 20;
        
        //private int xPos;
        //private int yPos;
        //private int mass;
        //private int spring;
        //private int damp; //fric?

        public Ball() : base()
        {

        }

        //public Ball(int mouseX, int mouseY) : base()
        //{
        //    UpdatePositionOnMouse(mouseX, mouseY);
        //}

        protected override void OnPaint(PaintEventArgs e)
        {
            //e.Graphics.FillEllipse(new SolidBrush(Color.White), this.xPos, this.yPos, this.xPos + radius, this.yPos + radius);
            e.Graphics.FillEllipse(new SolidBrush(Color.White), 0, 0, 10, 10);

        }

        //internal void UpdatePositionOnMouse(int mouseX, int mouseY)
        //{
        //    UpdatePosition(mouseX, mouseY);
        //    this.Invalidate();
        //}
        //
        //private void UpdatePosition(int x, int y)
        //{
        //    this.xPos = x - (int)(radius / 2);
        //    this.yPos = y - (int)(radius / 2);
        //}
    }
}
