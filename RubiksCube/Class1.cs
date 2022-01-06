using System;

namespace RubiksCube
{
    public enum Color
    {
        white,
        yellow,
        green,
        blue,
        orange,
        red
    }
    public class Side
    {
        public Color upEdge = Color.white;
        public Color rightEdge = Color.white;
        public Color downEdge = Color.white;
        public Color leftEdge = Color.white;
        public Color upRightAngle = Color.white;
        public Color upLeftAngle = Color.white;
        public Color downLeftAngle = Color.white;
        public Color downRightAngle = Color.white;
        public void ClockwiseTurn()
        {
            Color swap = upEdge;
            upEdge = leftEdge;
            leftEdge = downEdge;
            downEdge = rightEdge;
            rightEdge = swap;
            swap = upLeftAngle;
            upLeftAngle = downLeftAngle;
            downLeftAngle = downRightAngle;
            downRightAngle = upRightAngle;
            upRightAngle = swap;
        }
        public void ContrClockwiseTurn()
        {
            Color swap = upEdge;
            upEdge = rightEdge;
            rightEdge = downEdge;
            downEdge = leftEdge;
            leftEdge = swap;
            swap = upLeftAngle;
            upLeftAngle = upRightAngle;
            upRightAngle = downRightAngle;
            downRightAngle = downLeftAngle;
            downLeftAngle = swap;
        }
        public void DoubleTurn()
        {
            Color swap = upEdge;
            upEdge = downEdge;
            downEdge = swap;
            swap = rightEdge;
            rightEdge = leftEdge;
            leftEdge = swap;
            swap = upLeftAngle;
            upLeftAngle = downRightAngle;
            downRightAngle = swap;
            swap = upRightAngle;
            upRightAngle = downLeftAngle;
            downLeftAngle = swap;
        }
    }
    public class Cube
    {
        public Side whiteSide = new Side();
        public Side yellowSide = new Side();
        public Side greenSide = new Side();
        public Side blueSide = new Side();
        public Side orangeSide = new Side();
        public Side redSide = new Side();
        public string R()
        {
            orangeSide.ClockwiseTurn();
            Color swap = greenSide.upRightAngle;
            greenSide.upRightAngle = whiteSide.upRightAngle;
            whiteSide.upRightAngle = blueSide.upRightAngle;
            blueSide.upRightAngle = yellowSide.upRightAngle;
            yellowSide.upRightAngle = swap;
            swap = greenSide.rightEdge;
            greenSide.rightEdge = whiteSide.rightEdge;
            whiteSide.rightEdge = blueSide.rightEdge;
            blueSide.rightEdge = yellowSide.rightEdge;
            yellowSide.rightEdge = swap;
            swap = greenSide.downRightAngle;
            greenSide.downRightAngle = whiteSide.downRightAngle;
            whiteSide.downRightAngle = blueSide.downRightAngle;
            blueSide.downRightAngle = yellowSide.downRightAngle;
            yellowSide.downRightAngle = swap;
            return "R ";
        }
        public string RContr()
        {
            orangeSide.ContrClockwiseTurn();
            Color swap = greenSide.upRightAngle;
            greenSide.upRightAngle = yellowSide.upRightAngle;
            yellowSide.upRightAngle = blueSide.upRightAngle;
            blueSide.upRightAngle = whiteSide.upRightAngle;
            whiteSide.upRightAngle = swap;
            swap = greenSide.rightEdge;
            greenSide.rightEdge = yellowSide.rightEdge;
            yellowSide.rightEdge = blueSide.rightEdge;
            blueSide.rightEdge = whiteSide.rightEdge;
            whiteSide.rightEdge = swap;
            swap = greenSide.downRightAngle;
            greenSide.downRightAngle = yellowSide.downRightAngle;
            yellowSide.downRightAngle = blueSide.downRightAngle;
            blueSide.downRightAngle = whiteSide.downRightAngle;
            whiteSide.downRightAngle = swap;
            return "R'";
        }
        public string RDouble()
        {
            orangeSide.DoubleTurn();
            Color swap = greenSide.upRightAngle;
            greenSide.upRightAngle = blueSide.upRightAngle;
            blueSide.upRightAngle = swap;
            swap = whiteSide.upRightAngle;
            whiteSide.upRightAngle = yellowSide.upRightAngle;
            yellowSide.upRightAngle = swap;
            swap = greenSide.rightEdge;
            greenSide.rightEdge = blueSide.rightEdge;
            blueSide.rightEdge = swap;
            swap = whiteSide.rightEdge;
            whiteSide.rightEdge = yellowSide.rightEdge;
            yellowSide.rightEdge = swap;
            swap = greenSide.downRightAngle;
            greenSide.downRightAngle = blueSide.downRightAngle;
            blueSide.downRightAngle = swap;
            swap = whiteSide.downRightAngle;
            whiteSide.downRightAngle = yellowSide.downRightAngle;
            yellowSide.downRightAngle = swap;
            return "R2";
        }
        public string L()
        {
            redSide.ClockwiseTurn();
            Color swap = greenSide.upLeftAngle;
            greenSide.upLeftAngle = yellowSide.upLeftAngle;
            yellowSide.upLeftAngle = blueSide.upLeftAngle;
            blueSide.upLeftAngle = whiteSide.upLeftAngle;
            whiteSide.upLeftAngle = swap;
            swap = greenSide.leftEdge;
            greenSide.leftEdge = yellowSide.leftEdge;
            yellowSide.leftEdge = blueSide.leftEdge;
            blueSide.leftEdge = whiteSide.leftEdge;
            whiteSide.leftEdge = swap;
            swap = greenSide.downLeftAngle;
            greenSide.downLeftAngle = yellowSide.downLeftAngle;
            yellowSide.downLeftAngle = blueSide.downLeftAngle;
            blueSide.downLeftAngle = whiteSide.downLeftAngle;
            whiteSide.downLeftAngle = swap;
            return "L ";
        }
        public string LContr()
        {
            redSide.ClockwiseTurn();
            Color swap = greenSide.upLeftAngle;
            greenSide.upLeftAngle = whiteSide.upLeftAngle;
            whiteSide.upLeftAngle = blueSide.upLeftAngle;
            blueSide.upLeftAngle = yellowSide.upLeftAngle;
            yellowSide.upLeftAngle = swap;
            swap = greenSide.leftEdge;
            greenSide.leftEdge = whiteSide.leftEdge;
            whiteSide.leftEdge = blueSide.leftEdge;
            blueSide.leftEdge = yellowSide.leftEdge;
            yellowSide.leftEdge = swap;
            swap = greenSide.downLeftAngle;
            greenSide.downLeftAngle = whiteSide.downLeftAngle;
            whiteSide.downLeftAngle = blueSide.downLeftAngle;
            blueSide.downLeftAngle = yellowSide.downLeftAngle;
            yellowSide.downLeftAngle = swap;
            return "L'";
        }
        public string LDouble()
        {
            redSide.DoubleTurn();
            Color swap = greenSide.upLeftAngle;
            greenSide.upLeftAngle = blueSide.upLeftAngle;
            blueSide.upLeftAngle = swap;
            swap = whiteSide.upLeftAngle;
            whiteSide.upLeftAngle = yellowSide.upLeftAngle;
            yellowSide.upLeftAngle = swap;
            swap = greenSide.leftEdge;
            greenSide.leftEdge = blueSide.leftEdge;
            blueSide.leftEdge = swap;
            swap = whiteSide.leftEdge;
            whiteSide.leftEdge = yellowSide.leftEdge;
            yellowSide.leftEdge = swap;
            swap = greenSide.downLeftAngle;
            greenSide.downLeftAngle = blueSide.downLeftAngle;
            blueSide.downLeftAngle = swap;
            swap = whiteSide.downLeftAngle;
            whiteSide.downLeftAngle = yellowSide.downLeftAngle;
            yellowSide.downLeftAngle = swap;
            return "L2";
        }
        public string U()
        {
            UContr();
            UContr();
            UContr();
            return "U ";
        } 
        public string UContr()
        {
            yellowSide.ContrClockwiseTurn();
            Color swap = greenSide.upRightAngle;
            greenSide.upRightAngle = redSide.upRightAngle;
            redSide.upRightAngle = blueSide.downLeftAngle;
            blueSide.downLeftAngle = orangeSide.upRightAngle;
            orangeSide.upRightAngle = swap;
            swap = greenSide.upLeftAngle;
            greenSide.upLeftAngle = redSide.upLeftAngle;
            redSide.upLeftAngle = blueSide.downRightAngle;
            blueSide.downRightAngle = orangeSide.upLeftAngle;
            orangeSide.upLeftAngle = swap;
            swap = greenSide.upEdge;
            greenSide.upEdge = redSide.upEdge;
            redSide.upEdge = blueSide.downEdge;
            blueSide.downEdge = orangeSide.upEdge;
            orangeSide.upEdge = swap;
            return "U'";
        }
        public string UDouble()
        {
            yellowSide.DoubleTurn();
            Color swap = greenSide.upRightAngle;
            greenSide.upRightAngle = blueSide.downLeftAngle;
            blueSide.downLeftAngle = swap;
            swap = orangeSide.upRightAngle;
            orangeSide.upRightAngle = redSide.upRightAngle;
            redSide.upRightAngle = swap;
            swap = greenSide.upLeftAngle;
            greenSide.upLeftAngle = blueSide.downRightAngle;
            blueSide.downRightAngle = swap;
            swap = orangeSide.upLeftAngle;
            orangeSide.upLeftAngle = redSide.upLeftAngle;
            redSide.upLeftAngle = swap;
            swap = greenSide.upEdge;
            greenSide.upEdge = blueSide.downEdge;
            blueSide.downEdge = swap;
            swap = orangeSide.upEdge;
            orangeSide.upEdge = redSide.upEdge;
            redSide.upEdge = swap;
            return "U2";
        }
        public string D()
        {
            whiteSide.ClockwiseTurn();
            Color swap = greenSide.downRightAngle;
            greenSide.downRightAngle = redSide.downRightAngle;
            redSide.downRightAngle = blueSide.upLeftAngle;
            blueSide.upLeftAngle = orangeSide.downRightAngle;
            orangeSide.downRightAngle = swap;
            swap = greenSide.downLeftAngle;
            greenSide.downLeftAngle = redSide.downLeftAngle;
            redSide.downLeftAngle = blueSide.upRightAngle;
            blueSide.upRightAngle = orangeSide.downLeftAngle;
            orangeSide.downLeftAngle = swap;
            swap = greenSide.downEdge;
            greenSide.downEdge = redSide.downEdge;
            redSide.downEdge = blueSide.upEdge;
            blueSide.upEdge = orangeSide.downEdge;
            orangeSide.downEdge = swap;
            return "D ";
        }
        public string DContr()
        {
            whiteSide.ContrClockwiseTurn();
            Color swap = greenSide.downRightAngle;
            greenSide.downRightAngle = orangeSide.downRightAngle;
            orangeSide.downRightAngle = blueSide.upLeftAngle;
            blueSide.upLeftAngle = redSide.downRightAngle;
            redSide.downRightAngle = swap;
            swap = greenSide.downLeftAngle;
            greenSide.downLeftAngle = orangeSide.downLeftAngle;
            orangeSide.downLeftAngle = blueSide.upRightAngle;
            blueSide.upRightAngle = redSide.downLeftAngle;
            redSide.downLeftAngle = swap;
            swap = greenSide.downEdge;
            greenSide.downEdge = orangeSide.downEdge;
            orangeSide.downEdge = blueSide.upEdge;
            blueSide.upEdge = redSide.downEdge;
            redSide.downEdge = swap;
            return "D'";
        }
        public string DDouble()
        {
            whiteSide.DoubleTurn();
            Color swap = greenSide.downRightAngle;
            greenSide.downRightAngle = blueSide.upLeftAngle;
            blueSide.upLeftAngle = swap;
            swap = orangeSide.downRightAngle;
            orangeSide.downRightAngle = redSide.downRightAngle;
            redSide.downRightAngle = swap;
            swap = greenSide.downLeftAngle;
            greenSide.downLeftAngle = blueSide.upRightAngle;
            blueSide.upRightAngle = swap;
            swap = orangeSide.downLeftAngle;
            orangeSide.downLeftAngle = redSide.downLeftAngle;
            redSide.downLeftAngle = swap;
            swap = greenSide.downEdge;
            greenSide.downEdge = blueSide.upEdge;
            blueSide.upEdge = swap;
            swap = orangeSide.downEdge;
            orangeSide.downEdge = redSide.downEdge;
            redSide.downEdge = swap;
            return "D2";
        }
        public string F()
        {
            greenSide.ClockwiseTurn();
            Color swap = yellowSide.downLeftAngle;
            yellowSide.downLeftAngle = redSide.downRightAngle;
            redSide.downRightAngle = whiteSide.upRightAngle;
            whiteSide.upRightAngle = orangeSide.upLeftAngle;
            orangeSide.upLeftAngle = swap;
            swap = yellowSide.downRightAngle;
            yellowSide.downRightAngle = redSide.upRightAngle;
            redSide.upRightAngle = whiteSide.upLeftAngle;
            whiteSide.upLeftAngle = orangeSide.downLeftAngle;
            orangeSide.downLeftAngle = swap;
            swap = yellowSide.downEdge;
            yellowSide.downEdge = redSide.rightEdge;
            redSide.rightEdge = whiteSide.upEdge;
            whiteSide.upEdge = orangeSide.leftEdge;
            orangeSide.leftEdge = swap;
            return "F ";
        }
        public string FContr()
        {
            greenSide.ContrClockwiseTurn();
            Color swap = yellowSide.downLeftAngle;
            yellowSide.downLeftAngle = orangeSide.upLeftAngle;
            orangeSide.upLeftAngle = whiteSide.upRightAngle;
            whiteSide.upRightAngle = redSide.downRightAngle;
            redSide.downRightAngle = swap;
            swap = yellowSide.downRightAngle;
            yellowSide.downRightAngle = orangeSide.downLeftAngle;
            orangeSide.downLeftAngle = whiteSide.upLeftAngle;
            whiteSide.upLeftAngle = redSide.upRightAngle;
            redSide.upRightAngle = swap;
            swap = yellowSide.downEdge;
            yellowSide.downEdge = orangeSide.leftEdge;
            orangeSide.leftEdge = whiteSide.upEdge;
            whiteSide.upEdge = redSide.rightEdge;
            redSide.rightEdge = swap;
            return "F'";
        }
        public string FDouble()
        {

            F();
            F();
            return "F2";
        }
        public string B()
        {
            blueSide.ClockwiseTurn();
            Color swap = yellowSide.upLeftAngle;
            yellowSide.upLeftAngle = orangeSide.upRightAngle;
            orangeSide.upRightAngle = whiteSide.downRightAngle;
            whiteSide.downRightAngle = redSide.downLeftAngle;
            redSide.downLeftAngle = swap;
            swap = yellowSide.upRightAngle;
            yellowSide.upRightAngle = orangeSide.downRightAngle;
            orangeSide.downRightAngle = whiteSide.downLeftAngle;
            whiteSide.downLeftAngle = redSide.upLeftAngle;
            redSide.upLeftAngle = swap;
            swap = yellowSide.upEdge;
            yellowSide.upEdge = orangeSide.rightEdge;
            orangeSide.rightEdge = whiteSide.downEdge;
            whiteSide.downEdge = redSide.leftEdge;
            redSide.leftEdge = swap;
            return "B ";
        }
        public string BContr()
        {
            blueSide.ContrClockwiseTurn();
            Color swap = yellowSide.upLeftAngle;
            yellowSide.upLeftAngle = redSide.downLeftAngle;
            redSide.downLeftAngle = whiteSide.downRightAngle;
            whiteSide.downRightAngle = orangeSide.upRightAngle;
            orangeSide.upRightAngle = swap;
            swap = yellowSide.upRightAngle;
            yellowSide.upRightAngle = redSide.upLeftAngle;
            redSide.upLeftAngle = whiteSide.downLeftAngle;
            whiteSide.downLeftAngle = orangeSide.downRightAngle;
            orangeSide.downRightAngle = swap;
            swap = yellowSide.upEdge;
            yellowSide.upEdge = redSide.leftEdge;
            redSide.leftEdge = whiteSide.downEdge;
            whiteSide.downEdge = orangeSide.rightEdge;
            orangeSide.rightEdge = swap;
            return "B'";
        }
        public string BDouble()
        {
            blueSide.DoubleTurn();
            Color swap = yellowSide.upLeftAngle;
            yellowSide.upLeftAngle = whiteSide.downRightAngle;
            whiteSide.downRightAngle = swap;
            swap = orangeSide.upRightAngle;
            orangeSide.upRightAngle = redSide.downLeftAngle;
            redSide.downLeftAngle = swap;
            swap = yellowSide.upRightAngle;
            yellowSide.upRightAngle = whiteSide.downLeftAngle;
            whiteSide.downLeftAngle = swap;
            swap = orangeSide.downRightAngle;
            orangeSide.downRightAngle = redSide.upLeftAngle;
            redSide.upLeftAngle = swap;
            swap = yellowSide.upEdge;
            yellowSide.upEdge = whiteSide.downEdge;
            whiteSide.downEdge = swap;
            swap = orangeSide.rightEdge;
            orangeSide.rightEdge = redSide.leftEdge;
            redSide.leftEdge = swap;
            return "B2";
        }
    }
}
