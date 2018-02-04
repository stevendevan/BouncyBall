using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BouncyBall
{
    class Ball : Control // sealed?
    {
        private int radius;
        private int xPos;
        private int yPos;
        private int mass;
        private int spring;
        private int damp; //fric?

        public Ball()
        {
            //
        }

        protected override void OnPaint(PaintEventArgs e)
        {

        }
    }
}
