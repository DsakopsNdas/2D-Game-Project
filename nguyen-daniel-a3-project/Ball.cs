using System;
using System.Numerics;

namespace MohawkGame2D
{

    public class Ball
    {
        //variables
        Vector2 initPos;
        public Vector2 position;
        public Vector2 velocity = Vector2.Zero;
        public int radius;

        //due to sequencing issues with initPos and position, i can't use a constructor and splitting things up too much makes it a headache
        public void BallSetup()
        {
            radius = (Window.Height + Window.Width) / 200;
            initPos = new Vector2(Window.Width / 2, Window.Height / 2);
            Draw.Circle(initPos, radius);
            position = initPos;

            bool upOrDown = Random.Bool();
            bool rightOrLeft = Random.Bool();

            if (upOrDown == true)
            {
                velocity.Y = Random.Float(0, 1.5f);
            }
            else
            {
                velocity.Y = Random.Float(-1.5f, 0);
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
            position += velocity;
            Draw.Circle(position, radius);

            if (position.Y - radius <= 0)
            {
                velocity.Y *= -1;
            }
            if (position.Y + radius >= Window.Height)
            {
                velocity.Y *= -1;
            }
        }
    }
}