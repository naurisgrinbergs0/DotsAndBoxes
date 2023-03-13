using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwoPersonZeroSumGame.GameElements;

namespace TwoPersonZeroSumGame
{
    public class Game
    {
        public enum Player
        {
            Player1, Player2
        }

        // constants
        public static int GAME_MINIMUM_AI_COOLDOWN_MILLISECONDS = 500;
        public static int DOT_DIAMETER_MOUSE_OVER = 33;
        public static int DOT_DIAMETER = 30;
        public static int DOT_INTERACTIVE_MARGIN = 5;
        public static int LINE_WIDTH = 6;
        public static int CANVAS_PADDING = 20;
        public static int CANVAS_WIDTH;
        public static int CANVAS_HEIGHT;
        public static Color PLAYER1_COLOR = Color.Tomato;
        public static Color PLAYER2_COLOR = Color.RoyalBlue;
        public static Color ACCENT_COLOR = Color.Orange;

        // fields
        public List<List<Dot>> Dots = new List<List<Dot>>();
        public List<Line> Lines = new List<Line>();
        private List<Square> squares = new List<Square>();
        public bool GameFinished = false;
        private AI.AIPlayer ai;

        private Player playerFirstMove;
        private Player player;

        // getters/setters
        public void SetPlayer(Player player)
        {
            this.player = player;
        }
        public Player GetPlayer()
        {
            return player;
        }
        public AI.AIPlayer GetAI()
        {
            return ai;
        }

        public List<Square> GetSquares()
        {
            return squares;
        }

        public void SetCanvasSize(int width, int height)
        {
            CANVAS_WIDTH = width;
            CANVAS_HEIGHT = height;
        }

        // constructors
        public Game(int dotsHorizontal, int dotsVertical, Player playerFirstMove)
        {
            // populate list with dots
            for (int row = 0; row < dotsHorizontal; row++)
            {
                List<Dot> dotRow = new List<Dot>();
                Dots.Add(dotRow);
                for (int col = 0; col < dotsVertical; col++)
                {
                    dotRow.Add(new Dot(col, row));
                }
            }

            // make AI player
            ai = new AI.AIPlayer(Dots.Count, Dots[0].Count);

            this.playerFirstMove = playerFirstMove;
            player = playerFirstMove;
        }

        // methods
        private bool TryCreateSquares(Line line)
        {
            bool squareCreated = false;
            // get all connected perpendicular lines
            List<Line> allConnectedPerpendicular = Lines.Where(l =>
                line.IsLineHorizontal != l.IsLineHorizontal && l.AreLinesConnected(line)).ToList();

            // get parallel line that is connected to 2 perpendicular lines
            foreach (Line l in Lines.Where(l => l.AreLinesParallel(line)))
            {
                if (allConnectedPerpendicular.Where(lPerp => lPerp.AreLinesConnected(l)).Count() == 2)
                {
                    // sort dots & create a square
                    squares.Add(new Square(new List<Dot>() { line.DotFrom, line.DotTo, l.DotFrom, l.DotTo }, player));
                    if (squares.Count == (Dots.Count - 1) * (Dots[0].Count - 1))
                        GameFinished = true;
                    squareCreated = true;
                }
            }
            return squareCreated;
        }

        public bool TryCreateLine(Line line)
        {
            bool lineCreated = false;

            // add line to list
            if (Lines.Where(l => (l.DotFrom == line.DotFrom && l.DotTo == line.DotTo)
                 || (l.DotFrom == line.DotTo && l.DotTo == line.DotFrom)).Count() == 0)
            {
                // create squares if needed
                bool squareCreated = TryCreateSquares(line);

                Lines.Add(line);
                if (!squareCreated)
                    player = GetPlayer() == Game.Player.Player1 ? Game.Player.Player2 : Game.Player.Player1;

                lineCreated = true;
            }

            return lineCreated;
        }
    
        public void Restart()
        {
            this.player = playerFirstMove;
            Lines.Clear();
            squares.Clear();
            GameFinished = false;
        }
    
    }
}
