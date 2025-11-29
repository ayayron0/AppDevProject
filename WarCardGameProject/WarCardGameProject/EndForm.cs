using System;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WarCardGameProject
{
    public partial class EndForm : Form
    {
        private string winnerName;
        private string loserName;
        private int winnerScore;
        private int loserScore;
        //MainMenuForm menu;

        public EndForm(/*MainMemuForm hiddenMenu, */string winner, string loser/*, player 1's deck size, player 2's deck size*/)
        {
            InitializeComponent();
            winnerName = winner;
            winnerScore = 1; //temp num
            loserScore = 0; //temp num
            //menu = hiddenMenu;
        }

        private void EndForm_Load(object sender, EventArgs e)
        {
            statusLabel.Text = $"{winnerName} wins!";
            p1ScoreLabel.Text = $"{winnerName}: {winnerScore} cards left in their deck.";
            p2ScoreLabel.Text = $"{loserName}: {loserScore} cards left in their deck.";
        }

        //private void exitButton_Click(object sender, EventArgs e)
        //{
        //    Application.Exit();
        //}

        private void returnButton_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm(); //We shouldn't be making more forms, because it'll overload the player's pc.
            menu.Show();
            this.Hide();
        }
    }
}
