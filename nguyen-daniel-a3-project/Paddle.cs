namespace MohawkGame2D
{

	public class Paddle
	{
		public float[] cornerPositions = new float[7];
		public bool firstPaddle = true;
		int velocity = 0;
		
		public void PaddleSetup()
		{
			if (firstPaddle)
			{
				cornerPositions =
					[
					Window.Width / 8, Window.Height / 7 * 3, //top left corner
					Window.Width / 8 * 1.1f, Window.Height / 7 * 3, //top right corner
					Window.Width / 8 * 1.1f, Window.Height / 7 * 4, //bottom right corner
					Window.Width / 8, Window.Height / 7 * 4, //bottom left corner
					];
			}
			else if (firstPaddle == false)
			{
                cornerPositions = 
					[
					Window.Width / 8 * -1 + Window.Width, Window.Height / 7 * 3, //top left corner
					Window.Width / 8 * 1.1f * -1 + Window.Width, Window.Height / 7 * 3, //top right corner
                    Window.Width / 8 * 1.1f * -1 + Window.Width, Window.Height / 7 * 4, //bottom right corner
                    Window.Width / 8 * -1 + Window.Width, Window.Height / 7 * 4, //bottom left corner
                    ];
            }
		}
		public void Paddling()
		{
			Draw.Quad(
				cornerPositions[0], cornerPositions[1], 
				cornerPositions[2], cornerPositions[3],
                cornerPositions[4], cornerPositions[5], 
				cornerPositions[6], cornerPositions[7]
				);

			if (firstPaddle == true)
			{
				if (Input.IsKeyboardKeyDown(KeyboardInput.S) && cornerPositions[5] < Window.Height)
				{
					velocity = 2;
				}
				else if (Input.IsKeyboardKeyDown(KeyboardInput.W) && cornerPositions[1] > 0)
				{
					velocity = -2;
				}
				else
				{
					velocity = 0;
				}
			}
			else if (firstPaddle == false)
			{
                if (Input.IsKeyboardKeyDown(KeyboardInput.Down) && cornerPositions[5] < Window.Height)
                {
                    velocity = 2;
                }
                else if (Input.IsKeyboardKeyDown(KeyboardInput.Up) && cornerPositions[1] > 0)
                {
                    velocity = -2;
                }
                else
                {
                    velocity = 0;
                }
            }


            cornerPositions[1] += velocity;
            cornerPositions[3] += velocity;
            cornerPositions[5] += velocity;
            cornerPositions[7] += velocity;
        }
	}
}
