// Include the namespaces (code libraries) you need below.
using nguyen_daniel_a3_project;

// The namespace your code is in.
namespace MohawkGame2D
{
    /// <summary>
    ///     Your game code goes inside this class!
    /// </summary>
    public class Game
    {
        // Place your variables here:
        public Ball[] balls = new Ball[10];
        public Paddle paddle1 = new Paddle();
        public Paddle paddle2 = new Paddle();
        public Score score = new Score();

        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            balls = new Ball[10];
            balls[0] = new Ball();
            Window.SetTitle("Pong.");
            Window.SetSize(600, 400);
            Window.TargetFPS = 60;
            Draw.FillColor = Color.White;
            Draw.LineColor = Color.White;
            Text.Color = Color.White;
            balls[0].BallSetup();
            paddle1.PaddleSetup();
            paddle2.firstPaddle = false;
            paddle2.PaddleSetup();
        }

        public bool Paddle1Collision()
        {
            bool paddle1SideCollided = paddle1.cornerPositions[2] > balls[0].position.X - balls[0].radius;
            bool paddle1NotPassed = paddle1.cornerPositions[0] < balls[0].position.X + balls[0].radius;
            bool paddle1LowerThanTopPoint = balls[0].position.Y > paddle1.cornerPositions[1];
            bool paddle1HigherThanBottomPoint = balls[0].position.Y < paddle1.cornerPositions[5];
            bool paddle1Collided = paddle1SideCollided && paddle1NotPassed && paddle1LowerThanTopPoint && paddle1HigherThanBottomPoint;
            return paddle1Collided;
        }
        public bool Paddle2Collision()
        {
            bool paddle2SideCollided = paddle2.cornerPositions[2] < balls[0].position.X + balls[0].radius;
            bool paddle2NotPassed = paddle2.cornerPositions[0] > balls[0].position.X + balls[0].radius;
            bool paddle2LowerThanTopPoint = balls[0].position.Y > paddle2.cornerPositions[1];
            bool paddle2HigherThanBottomPoint = balls[0].position.Y < paddle2.cornerPositions[5];
            bool paddle2Collided = paddle2SideCollided && paddle2NotPassed && paddle2LowerThanTopPoint && paddle2HigherThanBottomPoint;
            return paddle2Collided;
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Window.ClearBackground(Color.Black);

            balls[0].Balling();
            paddle1.Paddling();
            paddle2.Paddling();

            if (Paddle1Collision() == true)
            {
                balls[0].velocity.X *= -1;
            }
            if (Paddle2Collision() == true)
            {
                balls[0].velocity.X *= -1;
            }
            if (balls[0].position.X + balls[0].radius <= Window.Width / Window.Width - 1)
            {
                balls[0].BallSetup();
                score.score.Y++;
            }
            if (balls[0].position.X - balls[0].radius >= Window.Width)
            {
                balls[0].BallSetup();
                score.score.X++;
            }

            score.DrawScoreText();
        }
    }

}
