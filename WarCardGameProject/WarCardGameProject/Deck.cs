using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WarCardGameProject
{
    public class Deck
    {
        private Card[] deck;
        private int numCards;

        public int NumCards => numCards;

        public Deck()
        {
            int position = 0;
            deck = new Card[54];
            for (int i = 1; i <= 4; i++)
            {
                for (int j = 1; j <= 13; j++)
                {
                    deck[position++] = new Card(i, j);
                }
            }
            deck[52] = new Joker(1);
            deck[53] = new Joker(2);
            numCards = 54;
        }

        public Deck(int deckSize)
        {
            deck = new Card[deckSize];
            numCards = 0;
        }

        public void Shuffle()
        {
            Random rand = new Random();
            for (int i = deck.Length - 1; i > 0; i--)
            {
                int r = rand.Next(i + 1);
                Card temp = deck[i];
                deck[i] = deck[r];
                deck[r] = temp;
            }
        }

        public void AddToDeck(Card card)
        {
            if (numCards < deck.Length)
            {
                deck[numCards] = card;
                numCards++;
            }
        }

        public void PrintDeck()
        {
            if (numCards <= 0)
            {
                Console.WriteLine("Empty deck");
            }
            else
            {
                for (int i = 0; i < numCards; i++)
                    Console.WriteLine(deck[i]);
            }
        }

        public Card DealCard(int position)
        {
            return deck[position];
        }

        public Card DealCard()
        {
            if (numCards > 0)
                return deck[--numCards];
            else
            {
                Console.WriteLine("Empty deck");
                return null;
            }
        }

        public void TransferCardsFrom(Deck fromDeck)
        {
            while (fromDeck.NumCards > 0)
            {
                AddToDeck(fromDeck.DealCard());
            }
        }

        public void TransferCardsToBottom(Deck fromDeck)
        {
            while (fromDeck.NumCards > 0)
            {
                AddToDeck(fromDeck.DealCard());
            }
        }
    }
}
