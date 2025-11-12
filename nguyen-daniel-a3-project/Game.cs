// Include the namespaces (code libraries) you need below.
using System;
using System.Numerics;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        Ball ball = new Ball();
        Paddle paddle1 = new Paddle();
        Paddle paddle2 = new Paddle();
        Vector2 score = Vector2.Zero;

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Pong.");
            Window.SetSize(600, 400);
            Window.TargetFPS = 60;
            Draw.FillColor = Color.White;
            Draw.LineColor = Color.Clear;
            Text.Color = Color.White;
            ball.BallSetup();
            paddle1.PaddleSetup();
            paddle2.firstPaddle = false;
            paddle2.PaddleSetup();
        }

        public Vector2 Scoring()
        {
            Text.Draw($"{score.X}", Window.Width / 3, Window.Height / 8);
            Text.Draw($"{score.Y}", Window.Width / 3 * 2, Window.Height / 8);

            if (ball.position.X + ball.radius <= Window.Width / Window.Width - 1)
            {
                ball.BallSetup();
                score.Y++;
                return score;
            }
            if (ball.position.X - ball.radius >= Window.Width)
            {
                ball.BallSetup();
                score.X++;
                return score;
            }
            else
            {
                return score;
            }
        }

        public bool PaddleCollision()
        {
            bool collided = false;
            return collided;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);
            ball.Balling();
            paddle1.Paddling();
            paddle2.Paddling();
            Scoring();
        }
    }

}
