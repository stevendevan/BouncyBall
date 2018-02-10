using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BouncyBall
{
    class BallPhysics
    {
        private float dt;
        private float g = 2000.0f;
        private float damping = 5.0f;
        private int xPos;
        private int yPos;
        private float xVel;
        private float yVel;

        public BallPhysics(int xCurr, int xPrev, int yCurr, int yPrev, float dt)
        {
            this.dt = dt;
            this.xPos = xCurr;
            this.yPos = yCurr;
            this.xVel = (int)((xCurr - xPrev) / dt);
            this.yVel = (int)((yCurr - yPrev) / dt);
        }

        public int DeltaPositionX()
        {
            this.xVel += this.damping * this.dt;
            this.xPos += (int)(this.xVel * this.dt);

            return this.xPos;
        }

        public int DeltaPositionY()
        {
            this.yVel += this.g * this.dt;
            this.yPos += (int)(this.yVel * this.dt);

            return this.yPos;
        }

        public int xPosition { get; set; }
        public int yPosition { get; set; }
    }
}
