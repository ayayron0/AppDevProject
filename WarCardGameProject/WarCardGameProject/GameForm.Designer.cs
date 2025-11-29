using System.Drawing;
using System.Windows.Forms;

namespace WarCardGameProject
{
    partial class GameForm
    {
        private Label lblPlayer1;
        private Label lblPlayer2;
        private Label lblP1Deck;
        private Label lblP2Deck;
        private Label lblWar;
        private Label lblRoundsLeft;

        private PictureBox picP1Card;
        private PictureBox picP2Card;

        private Button btnPlay;
        private Button btnRestart;
        private Button btnMenu;

        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblPlayer1 = new System.Windows.Forms.Label();
            this.lblPlayer2 = new System.Windows.Forms.Label();
            this.lblP1Deck = new System.Windows.Forms.Label();
            this.lblP2Deck = new System.Windows.Forms.Label();
            this.picP1Card = new System.Windows.Forms.PictureBox();
            this.picP2Card = new System.Windows.Forms.PictureBox();
            this.lblWar = new System.Windows.Forms.Label();
            this.lblRoundsLeft = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnRestart = new System.Windows.Forms.Button();
            this.btnMenu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picP1Card)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Card)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPlayer1
            // 
            this.lblPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPlayer1.ForeColor = System.Drawing.Color.White;
            this.lblPlayer1.Location = new System.Drawing.Point(107, 37);
            this.lblPlayer1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer1.Name = "lblPlayer1";
            this.lblPlayer1.Size = new System.Drawing.Size(133, 28);
            this.lblPlayer1.TabIndex = 0;
            this.lblPlayer1.Text = "Player 1";
            // 
            // lblPlayer2
            // 
            this.lblPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayer2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.lblPlayer2.ForeColor = System.Drawing.Color.White;
            this.lblPlayer2.Location = new System.Drawing.Point(867, 37);
            this.lblPlayer2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPlayer2.Name = "lblPlayer2";
            this.lblPlayer2.Size = new System.Drawing.Size(133, 28);
            this.lblPlayer2.TabIndex = 1;
            this.lblPlayer2.Text = "Player 2";
            // 
            // lblP1Deck
            // 
            this.lblP1Deck.BackColor = System.Drawing.Color.Transparent;
            this.lblP1Deck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblP1Deck.ForeColor = System.Drawing.Color.White;
            this.lblP1Deck.Location = new System.Drawing.Point(107, 86);
            this.lblP1Deck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP1Deck.Name = "lblP1Deck";
            this.lblP1Deck.Size = new System.Drawing.Size(133, 28);
            this.lblP1Deck.TabIndex = 2;
            this.lblP1Deck.Text = "Deck: 26";
            // 
            // lblP2Deck
            // 
            this.lblP2Deck.BackColor = System.Drawing.Color.Transparent;
            this.lblP2Deck.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblP2Deck.ForeColor = System.Drawing.Color.White;
            this.lblP2Deck.Location = new System.Drawing.Point(867, 86);
            this.lblP2Deck.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblP2Deck.Name = "lblP2Deck";
            this.lblP2Deck.Size = new System.Drawing.Size(133, 28);
            this.lblP2Deck.TabIndex = 3;
            this.lblP2Deck.Text = "Deck: 26";
            // 
            // picP1Card
            // 
            this.picP1Card.BackColor = System.Drawing.Color.Transparent;
            this.picP1Card.Location = new System.Drawing.Point(200, 185);
            this.picP1Card.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picP1Card.Name = "picP1Card";
            this.picP1Card.Size = new System.Drawing.Size(160, 197);
            this.picP1Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP1Card.TabIndex = 4;
            this.picP1Card.TabStop = false;
            // 
            // picP2Card
            // 
            this.picP2Card.BackColor = System.Drawing.Color.Transparent;
            this.picP2Card.Location = new System.Drawing.Point(733, 185);
            this.picP2Card.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.picP2Card.Name = "picP2Card";
            this.picP2Card.Size = new System.Drawing.Size(160, 197);
            this.picP2Card.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picP2Card.TabIndex = 5;
            this.picP2Card.TabStop = false;
            // 
            // lblWar
            // 
            this.lblWar.AutoSize = true;
            this.lblWar.BackColor = System.Drawing.Color.Transparent;
            this.lblWar.Font = new System.Drawing.Font("Segoe UI", 28F, System.Drawing.FontStyle.Bold);
            this.lblWar.ForeColor = System.Drawing.Color.Red;
            this.lblWar.Location = new System.Drawing.Point(453, 246);
            this.lblWar.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblWar.Name = "lblWar";
            this.lblWar.Size = new System.Drawing.Size(151, 62);
            this.lblWar.TabIndex = 6;
            this.lblWar.Text = "WAR!";
            this.lblWar.Visible = false;
            // 
            // lblRoundsLeft
            // 
            this.lblRoundsLeft.BackColor = System.Drawing.Color.Transparent;
            this.lblRoundsLeft.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblRoundsLeft.ForeColor = System.Drawing.Color.White;
            this.lblRoundsLeft.Location = new System.Drawing.Point(440, 37);
            this.lblRoundsLeft.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRoundsLeft.Name = "lblRoundsLeft";
            this.lblRoundsLeft.Size = new System.Drawing.Size(133, 28);
            this.lblRoundsLeft.TabIndex = 7;
            this.lblRoundsLeft.Text = "Rounds Left:";
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPlay.Location = new System.Drawing.Point(133, 468);
            this.btnPlay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(200, 49);
            this.btnPlay.TabIndex = 8;
            this.btnPlay.Text = "Play Round";
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnRestart
            // 
            this.btnRestart.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnRestart.Location = new System.Drawing.Point(427, 468);
            this.btnRestart.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRestart.Name = "btnRestart";
            this.btnRestart.Size = new System.Drawing.Size(200, 49);
            this.btnRestart.TabIndex = 10;
            this.btnRestart.Text = "Restart";
            this.btnRestart.Click += new System.EventHandler(this.btnRestart_Click);
            // 
            // btnMenu
            // 
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnMenu.Location = new System.Drawing.Point(754, 468);
            this.btnMenu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(200, 49);
            this.btnMenu.TabIndex = 11;
            this.btnMenu.Text = "Back to Menu";
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.lblPlayer1);
            this.Controls.Add(this.lblPlayer2);
            this.Controls.Add(this.lblP1Deck);
            this.Controls.Add(this.lblP2Deck);
            this.Controls.Add(this.picP1Card);
            this.Controls.Add(this.picP2Card);
            this.Controls.Add(this.lblWar);
            this.Controls.Add(this.lblRoundsLeft);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnRestart);
            this.Controls.Add(this.btnMenu);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "GameForm";
            this.Text = "War Card Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picP1Card)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picP2Card)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
