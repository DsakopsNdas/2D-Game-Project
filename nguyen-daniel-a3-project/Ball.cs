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
        Vector2 position;
        Vector2 velocity = Vector2.Zero;

        //due to sequencing issues with initPos and position, i can't use a constructor and splitting things up too much makes it a headache
        public void BallSetup()
        {
            initPos = new Vector2(Window.Width / 2, Window.Height / 2);
            position = initPos;

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

        //initial position needs to go in here so it gets the proper window width and height after the game has been setup
        public void Balling()
        {
            Draw.Circle(position, 5);
            position += velocity;
        }
    }
}