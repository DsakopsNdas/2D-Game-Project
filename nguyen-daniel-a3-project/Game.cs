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
            ball.BallSetup();
        }

        public Vector2 Scoring()
        {
            if (ball.position.X <= 0)
            {
                ball.BallSetup();
                score.Y++;
                return score;
            }
            if (ball.position.X >= 600)
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

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);
            Draw.FillColor = Color.White;
            Draw.LineColor = Color.Clear;
            ball.Balling();
            Scoring();
        }
    }

}
