using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwoPersonZeroSumGame
{
    public partial class MenuForm : Form
    {
        // enums
        public enum GameSize
        {
            SMALL, MEDIUM, BIG
        }

        // fields
        public int dotsHorizontal;
        public int dotsVertical;
        public Game.Player playerFirstMove = Game.Player.Player1;

        // constructors
        public MenuForm()
        {
            InitializeComponent();
            SelectGameSize(GameSize.MEDIUM);
            mediumSizeButton.FlatAppearance.BorderColor = Color.DarkOrange;
            mediumSizeButton.ForeColor = Color.DarkOrange;
            if (playerFirstMove == Game.Player.Player1)
                checkboxPlayer1.Checked = true;
            if (playerFirstMove == Game.Player.Player2)
                checkboxPlayer2.Checked = true;
        }

        // events

        private void StartButtonClick(object sender, EventArgs e)
        {
            GameForm gf = new GameForm();
            gf.InitializeGame(dotsHorizontal, dotsVertical, playerFirstMove, this);
            gf.Show();
            this.Hide();
        }

        private void SmallGameButtonPress(object sender, EventArgs e)
        {
            SelectGameSize(GameSize.SMALL);
            smallSizeButton.FlatAppearance.BorderColor = Color.DarkOrange;
            mediumSizeButton.FlatAppearance.BorderColor = Color.White;
            bigSizeButton.FlatAppearance.BorderColor = Color.White;
            smallSizeButton.ForeColor = Color.DarkOrange;
            mediumSizeButton.ForeColor = Color.White;
            bigSizeButton.ForeColor = Color.White;
        }

        private void MediumGameButtonPress(object sender, EventArgs e)
        {
            SelectGameSize(GameSize.MEDIUM);
            smallSizeButton.FlatAppearance.BorderColor = Color.White;
            mediumSizeButton.FlatAppearance.BorderColor = Color.DarkOrange;
            bigSizeButton.FlatAppearance.BorderColor = Color.White;
            smallSizeButton.ForeColor = Color.White;
            mediumSizeButton.ForeColor = Color.DarkOrange;
            bigSizeButton.ForeColor = Color.White;
        }

        private void BigGameButtonPress(object sender, EventArgs e)
        {
            SelectGameSize(GameSize.BIG);
            smallSizeButton.FlatAppearance.BorderColor = Color.White;
            mediumSizeButton.FlatAppearance.BorderColor = Color.White;
            bigSizeButton.FlatAppearance.BorderColor = Color.DarkOrange;
            smallSizeButton.ForeColor = Color.White;
            mediumSizeButton.ForeColor = Color.White;
            bigSizeButton.ForeColor = Color.DarkOrange;
        }

        // methods
        private void SelectGameSize(GameSize gameSize)
        {
            switch (gameSize)
            {
                case GameSize.SMALL:
                    dotsHorizontal = 5;
                    dotsVertical = 5;
                    break;
                default:
                case GameSize.MEDIUM:
                    dotsHorizontal = 7;
                    dotsVertical = 7;
                    break;
                case GameSize.BIG:
                    dotsHorizontal = 10;
                    dotsVertical = 10;
                    break;
            }
        }

        private void Player1LabelClick(object sender, EventArgs e)
        {
            checkboxPlayer1.Checked = true;
        }

        private void Player2LabelClick(object sender, EventArgs e)
        {
            checkboxPlayer2.Checked = true;
        }

        private void Player1RadioChecked(object sender, EventArgs e)
        {
            playerFirstMove = Game.Player.Player1;
        }

        private void Player2RadioChecked(object sender, EventArgs e)
        {
            playerFirstMove = Game.Player.Player2;
        }
    }
}
