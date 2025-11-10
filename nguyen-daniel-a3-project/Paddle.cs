using System;
using System.Numerics;

namespace MohawkGame2D
{

	public class Paddle
	{
		public float[] cornerPositions = new float[4];
		public bool firstPaddle = true;
		
		public void PaddleSetup()
		{
			if (firstPaddle)
			{
				cornerPositions =
					[
					Window.Width / 8, Window.Height / 4, //top left corner
					Window.Width / 8 * 2, Window.Height / 4 * 2, //top right corner
					Window.Width / 8 * 2, Window.Height / 4 * 2, //bottom right corner
					Window.Width / 8 * 2, Window.Height / 4 * 2, //bottom left corner
					];
			}
			else if (firstPaddle == false)
			{
                cornerPositions = 
					[
					Window.Width / 8 * -1 + Window.Width / 2, Window.Height / 4, //top left corner
					Window.Width / 8 * 2 * -1 + Window.Width / 2, Window.Height / 4 * 2, //top right corner
                    Window.Width / 8 * -1 + Window.Width / 2, Window.Height / 4, //bottom right corner
                    Window.Width / 8 * 2 * -1 + Window.Width / 2, Window.Height / 4 * 2, //bottom left corner
                    ];
            }
		}
		public void Paddling()
		{
			//Draw.Quad(cornerPositions[1], cornerPositions[2], cornerPositions[3], cornerPositions[4]);

        }
	}
}
