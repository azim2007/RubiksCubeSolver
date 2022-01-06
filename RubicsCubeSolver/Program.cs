using System;
using System.Collections.Generic;
using RubiksCube;

namespace RubicsCubeSolver
{
    class Program
    {
        enum Edge
        {
            up,
            right,
            left,
            down
        }
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
            Console.Write(side.upLeftAngle + " ");
            Console.Write(side.upEdge + " ");
            Console.Write(side.upRightAngle + " ");
            Console.Write(side.rightEdge + " ");
            Console.Write(side.downRightAngle + " ");
            Console.Write(side.downEdge + " ");
            Console.Write(side.downLeftAngle + " ");
            Console.Write(side.leftEdge + " ");
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
        static void PrintSolution(ref List<string> solution)
        {
            for(int i = 0; i < solution.Count; i++)
            {
                Console.Write(solution[i] + " ");
            }
        }
        static void OptimizeSolution(ref List<string> solution)
        {
            for(int i = 0; i < solution.Count - 1; i++)
            {
                if(solution[i][0] == solution[i + 1][0])
                {
                    int delta;
                    if(solution[i][1] == ' ')
                    {
                        delta = 1;
                    }
                    else if(solution[i][1] == '2')
                    {
                        delta = 2;
                    }
                    else
                    {
                        delta = -1;
                    }
                    if(solution[i + 1][1] == ' ')
                    {
                        delta = delta + 1;
                    }
                    else if(solution[i + 1][1] == '2')
                    {
                        delta = delta + 2;
                    }
                    else
                    {
                        delta = delta - 1;
                    }
                    solution.RemoveAt(i + 1);
                    if (delta == 0 || delta == 4)
                    {
                        solution.RemoveAt(i);
                    }
                    else if (delta == 1 || delta == 5)
                    {
                        solution[i] = Convert.ToString(solution[i][0]) + " ";
                    }
                    else if (delta == 2 || delta == -2)
                    {
                        solution[i] = Convert.ToString(solution[i][0]) + "2";
                    }
                    else if (delta == -1 || delta == 3)
                    {
                        solution[i] = Convert.ToString(solution[i][0]) + "\'";
                    }
                    i--;
                }
            }
        }
        static void Main(string[] args)
        {
            Cube cube = new Cube();
            List<string> solution = new List<string>();
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
            PrintCube(ref cube);
            Console.WriteLine();
            if(Checking(cube))
            {
                Console.WriteLine("Ваш куб собран!");
            }
            CrossOnOppositeSideSolve(ref cube, ref solution);
            CrossOnOppositeSideSolve(ref cube, ref solution);
            CrossOnOppositeSideSolve(ref cube, ref solution);
            CrossOnOppositeSideSolve(ref cube, ref solution);
            CrossSolve(ref cube, ref solution);
            PrintSolution(ref solution);
            OptimizeSolution(ref solution);
            Console.WriteLine();
            PrintSolution(ref solution);
        }
        static void PifPaf(ref Cube cube, ref List<string> solution)
        {
            solution.Add(cube.R());
            solution.Add(cube.U());
            solution.Add(cube.RContr());
            solution.Add(cube.UContr());
        }
        static bool Checking(Cube cube)
        {
            bool whiteSideSolved = (cube.whiteSide.upLeftAngle == Color.white) && (cube.whiteSide.upEdge == Color.white) && (cube.whiteSide.upRightAngle == Color.white) && (cube.whiteSide.rightEdge == Color.white) && (cube.whiteSide.downRightAngle == Color.white) && (cube.whiteSide.downEdge == Color.white) && (cube.whiteSide.downLeftAngle == Color.white) && (cube.whiteSide.leftEdge == Color.white);
            bool yellowSideSolved = (cube.yellowSide.upLeftAngle == Color.yellow) && (cube.yellowSide.upEdge == Color.yellow) && (cube.yellowSide.upRightAngle == Color.yellow) && (cube.yellowSide.rightEdge == Color.yellow) && (cube.yellowSide.downRightAngle == Color.yellow) && (cube.yellowSide.downEdge == Color.yellow) && (cube.yellowSide.downLeftAngle == Color.yellow) && (cube.yellowSide.leftEdge == Color.yellow);
            bool greenSideSolved = (cube.greenSide.upLeftAngle == Color.green) && (cube.greenSide.upEdge == Color.green) && (cube.greenSide.upRightAngle == Color.green) && (cube.greenSide.rightEdge == Color.green) && (cube.greenSide.downRightAngle == Color.green) && (cube.greenSide.downEdge == Color.green) && (cube.greenSide.downLeftAngle == Color.green) && (cube.greenSide.leftEdge == Color.green);
            bool blueSideSolved = (cube.blueSide.upLeftAngle == Color.blue) && (cube.blueSide.upEdge == Color.blue) && (cube.blueSide.upRightAngle == Color.blue) && (cube.blueSide.rightEdge == Color.blue) && (cube.blueSide.downRightAngle == Color.blue) && (cube.blueSide.downEdge == Color.blue) && (cube.blueSide.downLeftAngle == Color.blue) && (cube.blueSide.leftEdge == Color.blue);
            bool orangeSideSolved = (cube.orangeSide.upLeftAngle == Color.orange) && (cube.orangeSide.upEdge == Color.orange) && (cube.orangeSide.upRightAngle == Color.orange) && (cube.orangeSide.rightEdge == Color.orange) && (cube.orangeSide.downRightAngle == Color.orange) && (cube.orangeSide.downEdge == Color.orange) && (cube.orangeSide.downLeftAngle == Color.orange) && (cube.orangeSide.leftEdge == Color.orange);
            bool redSideSolved = (cube.redSide.upLeftAngle == Color.red) && (cube.redSide.upEdge == Color.red) && (cube.redSide.upRightAngle == Color.red) && (cube.redSide.rightEdge == Color.red) && (cube.redSide.downRightAngle == Color.red) && (cube.redSide.downEdge == Color.red) && (cube.redSide.downLeftAngle == Color.red) && (cube.redSide.leftEdge == Color.red);
            return whiteSideSolved && yellowSideSolved && greenSideSolved && blueSideSolved && orangeSideSolved && redSideSolved;
        }
        static void UpSideEdgeCheck(ref Cube cube, ref List<string> solution, Edge primary)
        {
            if (primary == Edge.up)
            {
                if (cube.yellowSide.upEdge != Color.white)
                {

                }
                else if (cube.yellowSide.leftEdge != Color.white)
                {
                    solution.Add(cube.U());
                }
                else if (cube.yellowSide.rightEdge != Color.white)
                {
                    solution.Add(cube.UContr());
                }
                else if (cube.yellowSide.downEdge != Color.white)
                {
                    solution.Add(cube.UDouble());
                }
            }
            else if(primary == Edge.right)
            {
                if (cube.yellowSide.rightEdge != Color.white)
                {

                }
                else if (cube.yellowSide.upEdge != Color.white)
                {
                    solution.Add(cube.U());
                }
                else if (cube.yellowSide.downEdge != Color.white)
                {
                    solution.Add(cube.UContr());
                }
                else if (cube.yellowSide.leftEdge != Color.white)
                {
                    solution.Add(cube.UDouble());
                }
            }
            else if(primary == Edge.down)
            {
                if (cube.yellowSide.downEdge != Color.white)
                {

                }
                else if (cube.yellowSide.rightEdge != Color.white)
                {
                    solution.Add(cube.U());
                }
                else if (cube.yellowSide.leftEdge != Color.white)
                {
                    solution.Add(cube.UContr());
                }
                else if (cube.yellowSide.upEdge != Color.white)
                {
                    solution.Add(cube.UDouble());
                }
            }
            else if(primary == Edge.left)
            {
                if (cube.yellowSide.leftEdge != Color.white)
                {

                }
                else if (cube.yellowSide.downEdge != Color.white)
                {
                    solution.Add(cube.U());
                }
                else if (cube.yellowSide.upEdge != Color.white)
                {
                    solution.Add(cube.UContr());
                }
                else if (cube.yellowSide.rightEdge != Color.white)
                {
                    solution.Add(cube.UDouble());
                }
            }
        }
        static void CrossOnOppositeSideSolve(ref Cube cube, ref List<string> solution)
        {
            
            if(cube.greenSide.upEdge == Color.white)
            {
                solution.Add(cube.F());
                solution.Add(cube.UContr());
                solution.Add(cube.R());
            }
            else if(cube.redSide.upEdge == Color.white)
            {
                solution.Add(cube.L());
                solution.Add(cube.UContr());
                solution.Add(cube.F());
            }
            else if(cube.orangeSide.upEdge == Color.white)
            {
                solution.Add(cube.R());
                solution.Add(cube.UContr());
                solution.Add(cube.B());
            }
            else if(cube.blueSide.downEdge == Color.white)
            {
                solution.Add(cube.B());
                solution.Add(cube.UContr());
                solution.Add(cube.L());
            }
            else if(cube.greenSide.rightEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.right);
                solution.Add(cube.R());
            }
            else if (cube.greenSide.leftEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.left);
                solution.Add(cube.LContr());
            }
            else if (cube.blueSide.leftEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.left);
                solution.Add(cube.L());
            }
            else if(cube.blueSide.rightEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.right);
                solution.Add(cube.RContr());
            }
            else if (cube.orangeSide.leftEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.down);
                solution.Add(cube.FContr());
            }
            else if (cube.orangeSide.rightEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.up);
                solution.Add(cube.B());
            }
            else if (cube.redSide.leftEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.up);
                solution.Add(cube.BContr());
            }
            else if (cube.redSide.rightEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.down);
                solution.Add(cube.F());
            }
            else if(cube.greenSide.downEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.down);
                solution.Add(cube.F());
                solution.Add(cube.U());
                solution.Add(cube.LContr());
            }
            else if(cube.orangeSide.downEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.right);
                solution.Add(cube.R());
                solution.Add(cube.U());
                solution.Add(cube.FContr());
            }
            else if (cube.redSide.downEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.left);
                solution.Add(cube.L());
                solution.Add(cube.U());
                solution.Add(cube.BContr());
            }
            else if (cube.blueSide.upEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.right);
                solution.Add(cube.B());
                solution.Add(cube.U());
                solution.Add(cube.RContr());
            }
            else if (cube.whiteSide.upEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.down);
                solution.Add(cube.FDouble());
            }
            else if (cube.whiteSide.rightEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.right);
                solution.Add(cube.RDouble());
            }
            else if (cube.whiteSide.leftEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.left);
                solution.Add(cube.LDouble());
            }
            else if (cube.whiteSide.downEdge == Color.white)
            {
                UpSideEdgeCheck(ref cube, ref solution, Edge.up);
                solution.Add(cube.BDouble());
            }
            if (Checking(cube))
            {
                PrintSolution(ref solution);
            }
        }
        static void CrossSolve(ref Cube cube, ref List<string> solution)
        {
            while(cube.whiteSide.upEdge != Color.white)
            {
                if (cube.greenSide.upEdge == Color.green && cube.yellowSide.downEdge == Color.white)
                {
                    solution.Add(cube.FDouble());
                }
                if (cube.orangeSide.upEdge == Color.orange && cube.yellowSide.rightEdge == Color.white)
                {
                    solution.Add(cube.RDouble());
                }
                if (cube.redSide.upEdge == Color.red && cube.yellowSide.leftEdge == Color.white)
                {
                    solution.Add(cube.LDouble());
                }
                if (cube.blueSide.downEdge == Color.blue && cube.yellowSide.upEdge == Color.white)
                {
                    solution.Add(cube.BDouble());
                }
                solution.Add(cube.U());
                if (Checking(cube))
                {
                    PrintSolution(ref solution);
                }
            }
        }
        static void WhiteSideSolve(ref Cube cube, ref List<string> solution)
        {
            if(cube.orangeSide.upLeftAngle == Color.white)
            {
                if(cube.yellowSide.downRightAngle == Color.orange)
                {
                    solution.Add(cube.R());
                    solution.Add(cube.U());
                    solution.Add(cube.RContr());
                }
                else if(cube.yellowSide.downRightAngle == Color.blue)
                {

                }
            }
        }
    }
}
