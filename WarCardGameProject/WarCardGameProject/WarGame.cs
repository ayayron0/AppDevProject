using System;

namespace WarCardGameProject
{
    public class RoundResult
    {
        public Card Player1Card { get; set; }
        public Card Player2Card { get; set; }
        public string Message { get; set; }
        public bool GameOver { get; set; }
        public string Winner { get; set; }
    }

    public class WarGame
    {
        public Player Player1 { get; private set; }
        public Player Player2 { get; private set; }

        private Deck tableDeck;
        private Deck initialDeck;

        public void StartGame(string p1Name, string p2Name)
        {
            Player1 = new Player(p1Name);
            Player2 = new Player(p2Name);

            tableDeck = new Deck(54);
            initialDeck = new Deck();

            for (int s = 0; s < 3; s++)
                initialDeck.Shuffle();

            for (int i = 0; i < 27; i++)
            {
                Player1.PlayerDeck.AddToDeck(initialDeck.DealCard(2 * i));
                Player2.PlayerDeck.AddToDeck(initialDeck.DealCard(2 * i + 1));
            }
        }

        public RoundResult PlayRound()
        {
            RoundResult result = new RoundResult();

            if (Player1.PlayerDeck.NumCards == 0)
            {
                result.GameOver = true;
                result.Winner = Player2.Name;
                return result;
            }
            if (Player2.PlayerDeck.NumCards == 0)
            {
                result.GameOver = true;
                result.Winner = Player1.Name;
                return result;
            }

            Card card1 = Player1.PlayerDeck.DealCard();
            Card card2 = Player2.PlayerDeck.DealCard();

            result.Player1Card = card1;
            result.Player2Card = card2;

            tableDeck.AddToDeck(card1);
            tableDeck.AddToDeck(card2);

            if (card1.Value > card2.Value)
            {
                Player1.PlayerDeck.TransferCardsFrom(tableDeck);
                result.Message = $"{Player1.Name} wins the round!";
            }
            else if (card2.Value > card1.Value)
            {
                Player2.PlayerDeck.TransferCardsFrom(tableDeck);
                result.Message = $"{Player2.Name} wins the round!";
            }
            else
            {
                result.Message = "Tie! Cards stay on the table.";
            }

            return result;
        }
    }
}
