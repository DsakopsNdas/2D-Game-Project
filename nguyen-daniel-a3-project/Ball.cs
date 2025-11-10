using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace MohawkGame2D
{

    public class Ball
    {
        //variables
        int veloX = 1;
        int veloY = 1;
        Vector2 initPos;
        public void Balling()
        {
            initPos = new Vector2(Window.Width / 2, Window.Height / 2);
            Draw.Circle(initPos, 5);
        }
    }
}