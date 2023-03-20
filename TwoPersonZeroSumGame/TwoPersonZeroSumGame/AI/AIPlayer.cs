using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoPersonZeroSumGame.GameElements;

namespace TwoPersonZeroSumGame.AI
{
    public class AIPlayer
    {
        // fields
        private int dotsHorizontal;
        private int dotsVertical;

        // construction
        public AIPlayer(int dotsHorizontal, int dotsVertical)
        {
            this.dotsHorizontal = dotsHorizontal;
            this.dotsVertical = dotsVertical;
        }

        // methods
        public void MakeLine(Game game)
        {
            if (game.GameFinished)
                return;

            // generate tree for a few of the next steps
            Node tree = GenerateGameTree(game, 2);

            // go through all direct children, calculate scores & save the best
            int bestScoreIndex = 0;
            int bestScore = GetGameStateScore(tree.Children[0].Lines);
            for(int i = 1; i < tree.Children.Count; i++)
            {
                // calculate score for game state
                int score = GetGameStateScore(tree.Children[i].Lines);
                if (score > bestScore)
                {
                    bestScoreIndex = i;
                    bestScore = score;
                }

                // go through all children of current node, calculate scores & save the worst
                int worstScore = GetGameStateScore(tree.Children[i].Children[0].Lines);
                for (int n = 1; n < tree.Children[i].Children.Count; n++)
                {
                    // calculate score for game state
                    int scoreChild = GetGameStateScore(tree.Children[i].Children[n].Lines);
                    if (scoreChild < worstScore)
                        worstScore = scoreChild;
                }

                score -= worstScore;
            }

            // get dots that make up the line
            Dot dotFrom = game.Dots.SelectMany(d => d).Where(d => d.Col == tree.Children[bestScoreIndex].Lines.Last()[0]
                && d.Row == tree.Children[bestScoreIndex].Lines.Last()[1]).ToList()[0];
            Dot dotTo = game.Dots.SelectMany(d => d).Where(d => d.Col == tree.Children[bestScoreIndex].Lines.Last()[2]
                && d.Row == tree.Children[bestScoreIndex].Lines.Last()[3]).ToList()[0];

            // make line that resulted in the best game state
            game.TryCreateLine(new Line(dotFrom, dotTo));
        }

        private Node GenerateGameTree(Game game, int depth)
        {
            Node nodeStart = new Node(game.Lines.Select(l => new int[] { 
                l.DotFrom.Col, l.DotFrom.Row, l.DotTo.Col, l.DotTo.Row }).ToList(), 0, 0);

            GenerateChildren(nodeStart, depth, game.GetPlayer());

            return nodeStart;
        }

        /// <summary>
        /// Generate children of the node & add them to it
        /// </summary>
        private void GenerateChildren(Node nodeCurrent, int depth, Game.Player player)
        {
            bool horizontalMode = true;
            int rowIterations = dotsVertical;
            int colIterations = dotsHorizontal - 1;

            Node node;
            List<int[]> lines;
            int[] line = null;
            bool lineCreated, squareCreated;
            // generate children
            for (int r = 0; r < rowIterations; r++)
            {
                for (int c = 0; c < colIterations; c++)
                {
                    // horizontal
                    if (horizontalMode)
                        line = new int[] { c, r, c + 1, r };
                    // vertical
                    if(!horizontalMode)
                        line = new int[] { c, r, c, r + 1 };

                    lines = new List<int[]>(nodeCurrent.Lines);
                    lineCreated = TryCreateLine(lines, line, out squareCreated);
                    if (lineCreated)
                    {
                        // add child
                        node = new Node(lines
                            , player == Game.Player.Player1 && squareCreated ? nodeCurrent.SquareCountPlayer1 + 1 : nodeCurrent.SquareCountPlayer1
                            , player == Game.Player.Player2 && squareCreated ? nodeCurrent.SquareCountPlayer2 + 1 : nodeCurrent.SquareCountPlayer2);
                        nodeCurrent.Children.Add(node);

                        // if depth is not reached - continue deeper in the tree
                        if (depth - 1 > 0)
                            GenerateChildren(node, depth - 1, player == Game.Player.Player1 ? Game.Player.Player2 : Game.Player.Player1);
                    }
                }
                if (r == rowIterations - 1 && horizontalMode)
                {
                    rowIterations--;
                    colIterations++;
                    r = -1;
                    horizontalMode = false;
                }
            }
        }




        // utility
        private static bool TryCreateLine(List<int[]> lines, int[] line, out bool squareCreated)
        {
            bool lineCreated = false;
            squareCreated = false;

            // add line to list
            if (lines.Where(l => AreLinesEqual(l, line)).Count() == 0)
            {
                // create squares if able
                squareCreated = TryCreateSquares(lines, line);
                lines.Add(line);

                lineCreated = true;
            }
            return lineCreated;
        }
        private static bool TryCreateSquares(List<int[]> lines, int[] line)
        {
            bool squareCreated = false;
            // get all connected perpendicular lines
            List<int[]> allConnectedPerpendicular = lines.Where(l =>
                IsLineHorizontal(line) != IsLineHorizontal(l) && AreLinesConnected(l, line)).ToList();

            // get parallel line that is connected to 2 perpendicular lines
            foreach (int[] l in lines.Where(l => AreLinesParallel(l, line)))
                if (allConnectedPerpendicular.Where(lPerp => AreLinesConnected(lPerp, l)).Count() == 2)
                    squareCreated = true;

            return squareCreated;
        }
        private static bool AreLinesEqual(int[] line1, int[] line2)
        {
            return line1[0] == line2[0] && line1[1] == line2[1] && line1[2] == line2[2] && line1[3] == line2[3];
        }
        private static bool IsLineHorizontal(int[] line)
        {
            return line[1] == line[3];
        }
        private static bool AreLinesConnected(int[] line1, int[] line2)
        {
            return (line1[0] == line2[0] && line1[1] == line2[1])
                || (line1[0] == line2[2] && line1[1] == line2[3])
                || (line1[2] == line2[0] && line1[3] == line2[1])
                || (line1[2] == line2[2] && line1[3] == line2[3]);
        }
        private static bool AreLinesParallel(int[] line1, int[] line2)
        {
            bool linesParallel = false;

            if (IsLineHorizontal(line1) && IsLineHorizontal(line2))
                linesParallel = (line1[0] == line2[0] && line1[2] == line2[2]);
            else if (!IsLineHorizontal(line1) && !IsLineHorizontal(line2))
                linesParallel = (line1[1] == line2[1] && line1[3] == line2[3]);

            return linesParallel;
        }
        private int GetGameStateScore(List<int[]> lines)
        {
            int score = 0;
            // go through all dots and get score of each area
            for (int row = 0; row < dotsVertical - 1; row++)
            {
                for (int col = 0; col < dotsHorizontal - 1; col++)
                {
                    // get score of current level
                    int numOfLinesInArea = lines.Where(l => AreLinesEqual(l, new int[] { col, row, col + 1, row })
                        || AreLinesEqual(l, new int[] { col, row, col, row + 1 })
                        || AreLinesEqual(l, new int[] { col, row + 1, col + 1, row + 1 })
                        || AreLinesEqual(l, new int[] { col + 1, row, col + 1, row + 1 })).Count();
                    if (numOfLinesInArea == 1)
                        score += 1;
                    else if (numOfLinesInArea == 2)
                        score += 2;
                    else if (numOfLinesInArea == 3)
                        score += -100;
                    else if (numOfLinesInArea == 4)
                        score += 100;
                }
            }

            return score;
        }
    }
}
