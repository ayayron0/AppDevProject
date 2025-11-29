using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGameProject
{
    public class Card
    {
        public int Suit { get; }
        public int Value { get; }

        public Card(int suit, int value)
        {
            Suit = suit;
            Value = value;
        }

        public virtual string GetSuitAsString()
        {
            switch (Suit)
            {
                case 1: return "Spades";
                case 2: return "Hearts";
                case 3: return "Diamonds";
                case 4: return "Clubs";
                default: return "Unknown";
            }
        }

        public virtual string GetValueAsString()
        {
            switch (Value)
            {
                case 1: return "Ace";
                case 11: return "Jack";
                case 12: return "Queen";
                case 13: return "King";
                default: return Value.ToString();
            }
        }

        public override string ToString()
        {
            return $"{GetValueAsString()} of {GetSuitAsString()}";
        }
    }
}
