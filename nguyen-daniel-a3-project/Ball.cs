using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MohawkGame2D
{

    public class Ball
    {
        //variables
        int veloX = 0;
        int veloY = 0;
        Vector2 initPos;
        Vector2 velocity = Vector2.Zero;

        public Ball()
        {
            bool upOrDown = Random.Bool();
            bool rightOrLeft= Random.Bool();
            
            if (upOrDown == true)
            {
                veloY = 1;
            }
            else
            {
                veloY = -1;
            }
            if (rightOrLeft == true)
            {
                veloX = 1;
            }
            else
            {
                veloX = -1;
            }
            velocity = new Vector2(veloX, veloY);
        }

        public void Balling()
        {
            initPos = new Vector2(Window.Width / 2, Window.Height / 2);
            Draw.Circle(initPos, 5);
            initPos += velocity;
        }
    }
}