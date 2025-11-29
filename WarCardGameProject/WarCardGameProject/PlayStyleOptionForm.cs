using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace WarCardGameProject
{
    public partial class PlayStyleOptionForm : Form
    {
        public static string SelectedMode = "PVP";
        public static int SelectedRounds = 5;
        private SoundPlayer hoverSound = new SoundPlayer(Properties.Resources.hover);
        private SoundPlayer clickSound = new SoundPlayer(Properties.Resources.click);

        public PlayStyleOptionForm()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            if (!pvpButton.Checked && !pvbButton.Checked)
            {
                MessageBox.Show("Please choose PVP or PVB.");
                return;
            }

            if (fiveRounds.Checked)
                SelectedRounds = 5;
            else if (tenRounds.Checked)
                SelectedRounds = 10;
            else if (fifteenRounds.Checked)
                SelectedRounds = 15;
            else
            {
                MessageBox.Show("Please select number of rounds.");
                return;
            }

            if (pvpButton.Checked)
                SelectedMode = "PVP";
            else
                SelectedMode = "PVB";

            GameForm gf = new GameForm(SelectedMode, SelectedRounds);
            gf.Show();
            this.Hide();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenuForm main = new MainMenuForm();
            main.Show();
            this.Hide();
        }


        private void AttachButtonEffects(Button btn)
        {
            btn.MouseEnter += (s, e) =>
            {
                try { hoverSound.Play(); } catch { }
                btn.BackColor = Color.FromArgb(50, 50, 50);
                btn.FlatAppearance.BorderColor = Color.White;
            };

            btn.MouseLeave += (s, e) =>
            {
                if (btn == backButton)
                {
                    btn.BackColor = Color.FromArgb(90, 0, 0);
                    btn.FlatAppearance.BorderColor = Color.DarkRed;
                }
                else
                {
                    btn.BackColor = Color.FromArgb(30, 30, 30);
                    btn.FlatAppearance.BorderColor = Color.Gold;
                }
            };

            btn.MouseDown += (s, e) =>
            {
                try { clickSound.Play(); } catch { }
                btn.BackColor = Color.FromArgb(70, 70, 70);
            };

            btn.MouseUp += (s, e) =>
            {
                btn.BackColor = Color.FromArgb(50, 50, 50);
            };
        }

        private void PlayStyleOptionForm_Load(object sender, EventArgs e)
        {
            AttachButtonEffects(startButton);
            AttachButtonEffects(backButton);
        }


    }
}
