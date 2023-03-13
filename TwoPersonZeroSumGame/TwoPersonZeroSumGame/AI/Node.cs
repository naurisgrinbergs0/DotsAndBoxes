using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoPersonZeroSumGame.GameElements;

namespace TwoPersonZeroSumGame.AI
{
    public class Node
    {
        // fields
        public List<int[]> Lines;
        public int SquareCountPlayer1;
        public int SquareCountPlayer2;

        public Node Parent;
        public List<Node> Children = new List<Node>();

        // constructors
        public Node(List<int[]> lines, int squareCountPlayer1, int squareCountPlayer2)
        {
            Lines = lines;
            SquareCountPlayer1 = squareCountPlayer1;
            SquareCountPlayer2 = squareCountPlayer2;
        }
    }
}
