using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPersonZeroSumGame.GameElements
{
    public class Dot
    {
        // fields
        public int Col;
        public int Row;
        private int canvasCenterX;
        private int canvasCenterY;

        // getters/setters
        public void SetCenterX(int canvasCenterX)
        {
            this.canvasCenterX = canvasCenterX;
        }
        public void SetCenterY(int canvasCenterY)
        {
            this.canvasCenterY = canvasCenterY;
        }
        public int GetCanvasCenterX()
        {
            return canvasCenterX;
        }
        public int GetCanvasCenterY()
        {
            return canvasCenterY;
        }

        // constructors
        public Dot(int col, int row)
        {
            Col = col;
            Row = row;
        }
    }
}
