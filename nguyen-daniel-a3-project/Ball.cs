using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MohawkGame2D
{

    public class Ball
    {
        //variables
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
                velocity.Y = 1;
            }
            else
            {
                velocity.Y = -1;
            }
            if (rightOrLeft == true)
            {
                velocity.X = 1;
            }
            else
            {
                velocity.X = -1;
            }
        }

        //initial position needs to go in here so it gets the proper window width and height after the game has been setup
        public void Balling()
        {
            Draw.Circle(position, 5);
            position += velocity;

            if (position.Y <= 0)
            {
                velocity.Y *= -1;
            }
            if (position.Y >= 400)
            {
                velocity.Y *= -1;
            }
            if (position.X <= 0)
            {
                velocity.X *= -1;
            }
            if (position.Y >= 400)
            {
                velocity.X *= -1;
            }
        }
    }
}