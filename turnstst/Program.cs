using System;
using RubiksCube;

namespace turnstst
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
        static void PrintSide(ref Side side)
        {
            Console.Write((int)side.upLeftAngle + " ");
            Console.Write((int)side.upEdge + " ");
            Console.Write((int)side.upRightAngle + " ");
            Console.Write((int)side.rightEdge + " ");
            Console.Write((int)side.downRightAngle + " ");
            Console.Write((int)side.downEdge + " ");
            Console.Write((int)side.downLeftAngle + " ");
            Console.Write((int)side.leftEdge + " ");
            Console.WriteLine();
        }
        static void PrintCube(ref Cube cube)
        {
            PrintSide(ref cube.yellowSide);
            PrintSide(ref cube.greenSide);
            PrintSide(ref cube.whiteSide);
            PrintSide(ref cube.blueSide);
            PrintSide(ref cube.orangeSide);
            PrintSide(ref cube.redSide);
        }
        static void Main(string[] args)
        {
            Random rand = new Random();
            Cube cube = new Cube();
            Cube cube2 = new Cube();
            Color[][] colors = new Color[6][];
            for (int j = 0; j < 6; j++)
            {
                colors[j] = new Color[8];
                for (int i = 0; i < 8; i++)
                {
                    colors[j][i] = (Color)rand.Next(0, 5);
                }
            }
            InputCube(colors, ref cube);
            PrintCube(ref cube);
            Console.WriteLine();
            cube2 = cube;
            cube2.RDouble();
            PrintCube(ref cube2);
            Console.WriteLine();
            
        }
    }
}
