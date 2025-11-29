using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGameProject
{
    public class Player
    {
        public string Name { get; }
        public Deck PlayerDeck { get; }

        public Player(string name)
        {
            Name = name;
            PlayerDeck = new Deck(54);
        }
    }
}
