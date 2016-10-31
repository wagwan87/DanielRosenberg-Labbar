using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labb5.Models
{
    class Game
    {
        public enum GameGenreType
        {
            RPG = 1,
            MMO,
            RTS,
            FPS,
            MOBA,
        }

        public GameGenreType GameGenre { get; set; }
        public string GameName { get; set; }

    }
}
