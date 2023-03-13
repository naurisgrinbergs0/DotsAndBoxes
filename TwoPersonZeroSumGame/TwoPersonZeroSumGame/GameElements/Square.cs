using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoPersonZeroSumGame.GameElements
{
    /// <summary>
    /// Square dots are always saved as follows: top left, top right, bottom left, bottom right
    /// </summary>
    public class Square
    {
        // fields
        public List<Dot> Dots;
        private Game.Player player;

        // getters/setters
        public void SetPlayer(Game.Player player)
        {
            this.player = player;
        }
        public Game.Player GetPlayer()
        {
            return player;
        }

        // constructors
        public Square(List<Dot> dots, Game.Player player)
        {
            // assures that dots are saved in correct order
            Dots = dots.OrderBy(d => d.Row).ThenBy(d => d.Col).ToList();
            this.player = player;
        }
    }
}
