using System;
using RubiksCube;

namespace RubicsCubeSolver
{
    class Program
    {
        static void InputSide(Color[] colors, ref Side sideOfCube)
        {
            sideOfCube.upLeftAngle = colors[0];
            sideOfCube.upEdge = colors[1];
            sideOfCube.upRightAngle = colors[2];
            sideOfCube.rightEdge = colors[3];
            sideOfCube.downRightAngle = colors[4];
            sideOfCube.downEdge = colors[5];
            sideOfCube.downLeftAngle = colors[6];
            sideOfCube.leftEdge = colors[7];

        }
        static void InputCube(Color[][] colors, ref Cube cube)
        {
            InputSide(colors[0], ref cube.yellowSide);
            InputSide(colors[1], ref cube.greenSide);
            InputSide(colors[2], ref cube.whiteSide);
            InputSide(colors[3], ref cube.blueSide);
            InputSide(colors[4], ref cube.orangeSide);
            InputSide(colors[5], ref cube.redSide);
        }
        static void Main(string[] args)
        {
            Cube cube = new Cube();
            Color[][] colors = new Color[6][];
            for(int j = 0; j < 6; j++)
            {
                colors[j] = new Color[8];
                var a = Console.ReadLine().Split(" ");
                for (int i = 0; i < 8; i++)
                {
                    colors[j][i] = (Color)int.Parse(a[i]);
                }
            }
            InputCube(colors, ref cube);
            
        }
        static void CrossOnOppositeSideSolve(ref Cube cube)
        {

        }
    }
}
