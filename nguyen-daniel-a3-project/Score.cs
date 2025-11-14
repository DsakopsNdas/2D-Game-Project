using MohawkGame2D;
using System.Numerics;

namespace nguyen_daniel_a3_project
{
    public class Score
    {
        public Vector2 score = Vector2.Zero;
        public void DrawScoreText()
        {
            Text.Draw($"{score.X}", Window.Width / 3, Window.Height / 8);
            Text.Draw($"{score.Y}", Window.Width / 3 * 2, Window.Height / 8);
        }
    }
}
