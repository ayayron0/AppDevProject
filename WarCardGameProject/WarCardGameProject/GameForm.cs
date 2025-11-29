using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WarCardGameProject
{
    public partial class GameForm : Form
    {
        private string gameMode;
        private int totalRounds;
        private int currentRound = 0;

        private bool isPaused = false;

        private WarGame game;

        public GameForm(string mode, int rounds)
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            gameMode = mode;
            totalRounds = rounds;
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            StartNewGame();
        }

        // ------------------------------
        //  START GAME
        // ------------------------------
        private void StartNewGame()
        {
            game = new WarGame();

            if (gameMode == "PVB")
                game.StartGame(SettingForm.P1Name, "Bot");
            else
                game.StartGame(SettingForm.P1Name, SettingForm.P2Name);

            lblPlayer1.Text = game.Player1.Name;
            lblPlayer2.Text = game.Player2.Name;

            currentRound = 0;
            lblRoundsLeft.Text = $"Rounds Left: {totalRounds}";
            picP1Card.Image = null;
            picP2Card.Image = null;
            lblWar.Visible = false;

            UpdateUI();
        }

        // ------------------------------
        //  PLAY ROUND (ANIMATED)
        // ------------------------------
        private async void btnPlay_Click(object sender, EventArgs e)
        {
            if (isPaused)
                return;

            if (currentRound >= totalRounds)
            {
                MessageBox.Show("All rounds completed!");
                EndGame();
                return;
            }

            currentRound++;

            RoundResult result = game.PlayRound();

            // Animate card reveal
            await AnimateCard(picP1Card, result.Player1Card);
            await AnimateCard(picP2Card, result.Player2Card);

            // WAR?
            if (result.Message.Contains("WAR"))
                lblWar.Visible = true;
            else
                lblWar.Visible = false;

            UpdateUI();

            if (result.GameOver)
                EndGame(result.Winner);
        }

        // ------------------------------
        //  CARD ANIMATION
        // ------------------------------
        private async Task AnimateCard(PictureBox pic, Card card)
        {
            try
            {
                string imagePath = System.IO.Path.Combine(Application.StartupPath, "img", $"{card.Value}.png");

                if (System.IO.File.Exists(imagePath))
                    pic.Image = Image.FromFile(imagePath);
                else
                    pic.Image = null;
            }
            catch
            {
                pic.Image = null;
            }

            int startX = pic.Left;

            // slide right
            for (int i = 0; i < 10; i++)
            {
                pic.Left += 3;
                await Task.Delay(15);
            }

            // slide back
            for (int i = 0; i < 10; i++)
            {
                pic.Left -= 3;
                await Task.Delay(15);
            }

            pic.Left = startX;
        }

        // ------------------------------
        //  UPDATE UI
        // ------------------------------
        private void UpdateUI()
        {
            lblP1Deck.Text = $"Deck: {game.Player1.PlayerDeck.NumCards}";
            lblP2Deck.Text = $"Deck: {game.Player2.PlayerDeck.NumCards}";

            int roundsLeft = totalRounds - currentRound;
            lblRoundsLeft.Text = $"Rounds Left: {roundsLeft}";

            if (roundsLeft <= 0)
                EndGame();
        }

        // ------------------------------
        //  RESTART GAME
        // ------------------------------
        private void btnRestart_Click(object sender, EventArgs e)
        {
            StartNewGame();
        }

        // ------------------------------
        //  END GAME
        // ------------------------------
        private void EndGame(string winner = null)
        {
            if (winner == null)
            {
                winner = game.Player1.PlayerDeck.NumCards >
                         game.Player2.PlayerDeck.NumCards
                         ? game.Player1.Name
                         : game.Player2.Name;
            }

            EndForm end = new EndForm(winner);
            end.Show();
            this.Hide();
        }

        // ------------------------------
        //  BACK TO MENU
        // ------------------------------
        private void btnMenu_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Hide();
        }
    }
}
