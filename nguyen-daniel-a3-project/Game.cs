// Include the namespaces (code libraries) you need below.
using nguyen_daniel_a3_project;
using System;
using System.Drawing;
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
        public Ball ball = new Ball();
        public Paddle paddle1 = new Paddle();
        public Paddle paddle2 = new Paddle();
        public Score score = new Score();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("Pong.");
            Window.SetSize(600, 400);
            Window.TargetFPS = 60;
            Draw.FillColor = Color.White;
            Draw.LineColor = Color.White;
            Text.Color = Color.White;
            ball.BallSetup();
            paddle1.PaddleSetup();
            paddle2.firstPaddle = false;
            paddle2.PaddleSetup();
        }

        public bool Paddle1Collision()
        {
            bool paddle1SideCollided = paddle1.cornerPositions[2] > ball.position.X - ball.radius;
            bool paddle1LowerThanTopPoint = ball.position.Y > paddle1.cornerPositions[1];
            bool paddle1HigherThanBottomPoint = ball.position.Y < paddle1.cornerPositions[5];
            bool paddle1Collided = paddle1SideCollided && paddle1LowerThanTopPoint && paddle1HigherThanBottomPoint;
            return paddle1Collided;
        }
        public bool Paddle2Collision()
        {
            bool paddle2SideCollided = paddle2.cornerPositions[2] < ball.position.X + ball.radius;
            bool paddle2LowerThanTopPoint = ball.position.Y > paddle2.cornerPositions[1];
            bool paddle2HigherThanBottomPoint = ball.position.Y < paddle2.cornerPositions[5];
            bool paddle2Collided = paddle2SideCollided && paddle2LowerThanTopPoint && paddle2HigherThanBottomPoint;
            return paddle2Collided;
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

            if (Paddle1Collision() == true)
            {
                ball.velocity.X *= -1;
            }
            if (Paddle2Collision() == true)
            {
                ball.velocity.X *= -1;
            }
            if (ball.position.X + ball.radius <= Window.Width / Window.Width - 1)
            {
                ball.BallSetup();
                score.score.Y++;
            }
            if (ball.position.X - ball.radius >= Window.Width)
            {
                ball.BallSetup();
                score.score.X++;
            }

            score.DrawScoreText();
        }
    }

}
