using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TwoPersonZeroSumGame.GameElements;

namespace TwoPersonZeroSumGame
{
    public partial class GameForm : Form
    {
        // fields
        Game game;
        Dot dotSelected;
        Dot dotMouseOver;
        DateTime lastMoveTime;
        MenuForm menuForm;

        // pens & brushes
        Brush dotBrush;
        Pen linePen;
        Brush squareBrushPlayer1;
        Brush squareBrushPlayer2;

        // constructors
        public GameForm()
        {
            InitializeComponent();
        }

        // metods
        public void InitializeGame(int dotsHorizontal, int dotsVertical, Game.Player playerFirstMove, MenuForm menuForm)
        {
            this.menuForm = menuForm;

            // set params
            game = new Game(dotsHorizontal, dotsVertical, playerFirstMove);
            game.SetCanvasSize(gameCanvas.Bounds.Width, gameCanvas.Bounds.Height);

            // start timer
            gameTimer.Enabled = true;

            // init brushes & pens
            dotBrush = new SolidBrush(Color.FromArgb(30, 30, 30));
            linePen = new Pen(Game.ACCENT_COLOR, Game.LINE_WIDTH);
            squareBrushPlayer1 = new SolidBrush(Game.PLAYER1_COLOR);
            squareBrushPlayer2 = new SolidBrush(Game.PLAYER2_COLOR);

            // set up ui
            labelPlayer1Score.ForeColor = Game.PLAYER1_COLOR;
            labelPlayer2Score.ForeColor = Game.PLAYER2_COLOR;
            labelPlayer1.ForeColor = Game.PLAYER1_COLOR;
            labelPlayer2.ForeColor = Game.PLAYER2_COLOR;

            UpdateLabels();
        }

        // events
        private void GameTimerTick(object sender, EventArgs e)
        {
            if (game.GameFinished)
                gameTimer.Enabled = false;
            gameCanvas.Invalidate();
        }

        private void UpdatePictureBoxGraphics(object sender, PaintEventArgs e)
        {
            // set variables
            Graphics c = e.Graphics;

            List<List<Dot>> dots = game.Dots;
            int dotCols = dots[0].Count;
            int dotRows = dots.Count;
            List<Line> lines = game.Lines;


            // draw squares
            foreach (Square square in game.GetSquares())
            {
                c.FillRectangle(square.GetPlayer() == Game.Player.Player1 ? squareBrushPlayer1 : squareBrushPlayer2
                    , square.Dots[0].GetCanvasCenterX()
                    , square.Dots[1].GetCanvasCenterY()
                    , square.Dots[1].GetCanvasCenterX() - square.Dots[0].GetCanvasCenterX()
                    , square.Dots[2].GetCanvasCenterY() - square.Dots[0].GetCanvasCenterY()
                    );
            }

            // draw all lines
            foreach (Line line in lines)
            {
                c.DrawLine(linePen
                    , line.DotFrom.GetCanvasCenterX()
                    , line.DotFrom.GetCanvasCenterY()
                    , line.DotTo.GetCanvasCenterX()
                    , line.DotTo.GetCanvasCenterY()
                    );
            }

            // draw line from selected dot
            if (dotSelected != null)
            {
                c.DrawLine(linePen
                    , dotSelected.GetCanvasCenterX()
                    , dotSelected.GetCanvasCenterY()
                    , mouseX
                    , mouseY
                    );
            }



            // calculate dot positions
            int marginBetweenDots = (Game.CANVAS_WIDTH < Game.CANVAS_HEIGHT)
                ? (Game.CANVAS_WIDTH - 2 * Game.CANVAS_PADDING - dotCols * Game.DOT_DIAMETER) / (dotCols - 1)
                : (Game.CANVAS_HEIGHT - 2 * Game.CANVAS_PADDING - dotRows * Game.DOT_DIAMETER) / (dotRows - 1);
            int verticalOffset = Game.CANVAS_PADDING + (Game.CANVAS_HEIGHT - 2 * Game.CANVAS_PADDING - game.Dots.Count 
                * Game.DOT_DIAMETER - (game.Dots.Count - 1) * marginBetweenDots) / 2;
            int horizontalOffsetInitial = Game.CANVAS_PADDING + (Game.CANVAS_WIDTH - 2 * Game.CANVAS_PADDING - game.Dots[0].Count
                * Game.DOT_DIAMETER - (game.Dots[0].Count - 1) * marginBetweenDots) / 2;
            // draw all dots
            foreach (List<Dot> dotRow in dots)
            {
                int horizontalOffset = horizontalOffsetInitial;
                foreach (Dot dot in dotRow)
                {
                    if (dot == dotMouseOver)
                    {
                        c.FillEllipse(dotBrush, new Rectangle(
                        horizontalOffset - (Game.DOT_DIAMETER_MOUSE_OVER - Game.DOT_DIAMETER) / 2
                        , verticalOffset - (Game.DOT_DIAMETER_MOUSE_OVER - Game.DOT_DIAMETER) / 2
                        , Game.DOT_DIAMETER_MOUSE_OVER
                        , Game.DOT_DIAMETER_MOUSE_OVER
                        ));
                    }
                    else
                    {
                        c.FillEllipse(dotBrush, new Rectangle(
                        horizontalOffset
                        , verticalOffset
                        , Game.DOT_DIAMETER
                        , Game.DOT_DIAMETER
                        ));
                    }
                    dot.SetCenterX(horizontalOffset + Game.DOT_DIAMETER / 2);
                    dot.SetCenterY(verticalOffset + Game.DOT_DIAMETER / 2);
                    horizontalOffset += Game.DOT_DIAMETER + marginBetweenDots;
                }
                verticalOffset += Game.DOT_DIAMETER + marginBetweenDots;
            }

            // set cursor appearance
            this.Cursor = (dotMouseOver != null || dotSelected != null)
                ? Cursors.Hand
                : Cursors.Default;

            // wait a while when AI making a move
            if (game.GetPlayer() == Game.Player.Player2 && DateTime.Now - lastMoveTime > new TimeSpan(0, 0, 0, 0, Game.GAME_MINIMUM_AI_COOLDOWN_MILLISECONDS))
            {
                game.GetAI().MakeLine(game);
                OnLineCreated();
            }
        }

        // mouse events
        private int mouseX;
        private int mouseY;

        private void MouseDown(object sender, MouseEventArgs e)
        {
            // check if mouse button is pressed on a dot
            Dot dotUnderMouse = GetDotUnderMouse(e.X, e.Y);
            if (dotUnderMouse != null)
            {
                dotSelected = dotUnderMouse;
                mouseX = e.X;
                mouseY = e.Y;
            }
        }

        private void MouseMove(object sender, MouseEventArgs e)
        {
            // store mouse position
            mouseX = e.X;
            mouseY = e.Y;

            dotMouseOver = GetDotUnderMouse(e.X, e.Y);
        }

        private void MouseUp(object sender, MouseEventArgs e)
        {
            Dot dotUnderMouse = GetDotUnderMouse(e.X, e.Y);
            if (dotUnderMouse != null && dotSelected != null)
            {
                if (dotSelected.Col == dotUnderMouse.Col && Math.Abs(dotSelected.Row - dotUnderMouse.Row) == 1
                    || dotSelected.Row == dotUnderMouse.Row && Math.Abs(dotSelected.Col - dotUnderMouse.Col) == 1
                    && game.GetPlayer() == Game.Player.Player1)
                {
                    // create line & try to add
                    Line line = new Line(dotSelected, dotUnderMouse);
                    bool lineCreated = game.TryCreateLine(line);

                    if (lineCreated)
                        OnLineCreated();
                }
            }

            dotSelected = null;
        }

        // utility
        private void OnLineCreated()
        {
            lastMoveTime = DateTime.Now;
            UpdateLabels();
        }

        private void UpdateLabels()
        {
            // update score
            labelPlayer1Score.Text = game.GetSquares().Where(s => s.GetPlayer() == Game.Player.Player1).Count().ToString();
            labelPlayer2Score.Text = game.GetSquares().Where(s => s.GetPlayer() == Game.Player.Player2).Count().ToString();

            // update info
            if (!game.GameFinished)
                labelInfo.Text = game.GetPlayer() == Game.Player.Player1 ? "User's Turn" : "Computer's Turn";
            else
            {
                int player1Squares = game.GetSquares().Where(s => s.GetPlayer() == Game.Player.Player1).Count();
                int player2Squares = game.GetSquares().Where(s => s.GetPlayer() == Game.Player.Player2).Count();
                if (player1Squares > player2Squares)
                    labelInfo.Text = "User Wins!";
                else if (player1Squares < player2Squares)
                    labelInfo.Text = "Computer Wins!";
                else
                    labelInfo.Text = "Tie!";
            }
        }

        private Dot GetDotUnderMouse(int mouseX, int mouseY)
        {
            foreach (List<Dot> dotRow in game.Dots)
                foreach (Dot d in dotRow)
                    if (Math.Sqrt(Math.Pow(mouseX - d.GetCanvasCenterX(), 2) + Math.Pow(mouseY - d.GetCanvasCenterY(), 2))
                        < Game.DOT_DIAMETER / 2 + Game.DOT_INTERACTIVE_MARGIN)
                        return d;
            return null;
        }

        private void OnRestartClick(object sender, EventArgs e)
        {
            game.Restart();
            gameTimer.Enabled = true;
            UpdateLabels();
        }

        private void OnMainMenuClick(object sender, EventArgs e)
        {
            this.Hide();
            menuForm.Show();
            menuForm.Activate();
        }

        private void OnFormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            menuForm.Show();
            menuForm.Activate();
        }
    }
}
