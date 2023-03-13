using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPersonZeroSumGame.GameElements
{
    /// <summary>
    /// Line always starts from lowest coordinate and goes to highest coordinate
    /// </summary>
    public class Line
    {
        // fields
        public Dot DotFrom;
        public Dot DotTo;

        // getters/setters
        public bool IsLineHorizontal
        {
            get => DotFrom.Row == DotTo.Row;
        }

        // constructors
        public Line(Dot dot1, Dot dot2)
        {
            // the following code assures that the line goes from lower to higher coordinate
            // if line is horizontal
            if(dot1.Row == dot2.Row)
            {
                DotFrom = (dot1.Col < dot2.Col) ? dot1 : dot2;
                DotTo = (dot1.Col < dot2.Col) ? dot2 : dot1;
            }
            // if line is vertical
            else if (dot1.Col == dot2.Col)
            {
                DotFrom = (dot1.Row < dot2.Row) ? dot1 : dot2;
                DotTo = (dot1.Row < dot2.Row) ? dot2 : dot1;
            }
        }

        // methods
        public bool AreLinesConnected(Line line)
        {
            return DotFrom == line.DotFrom || DotFrom == line.DotTo
                || DotTo == line.DotFrom || DotTo == line.DotTo;
        }
        public bool AreLinesParallel(Line line)
        {
            bool linesParallel = false;

            if (IsLineHorizontal && line.IsLineHorizontal)
                linesParallel = (DotFrom.Col == line.DotFrom.Col && DotTo.Col == line.DotTo.Col);
            else if (!IsLineHorizontal && !line.IsLineHorizontal)
                linesParallel = (DotFrom.Row == line.DotFrom.Row && DotTo.Row == line.DotTo.Row);

            return linesParallel;
        }
    }
}
