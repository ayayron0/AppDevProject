using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace WarCardGameProject
{
    public partial class SettingForm : Form
    {
        public static string P1Name = "Player 1";
        public static string P2Name = "Player 2";

        // Saved state BEFORE entering settings
        public static bool SavedMusicSetting = true;

        private SoundPlayer hoverSound = new SoundPlayer(Properties.Resources.hover);
        private SoundPlayer clickSound = new SoundPlayer(Properties.Resources.click);

        public SettingForm()
        {
            InitializeComponent();

            // Load names
            txtP1Name.Text = P1Name;
            txtP2Name.Text = P2Name;

            if (PlayStyleOptionForm.SelectedMode == "PVB")
            {
                txtP2Name.Text = "Bot";
                txtP2Name.Enabled = false;
            }

            // Load the temporary state (same as MusicManager initially)
            musicToggleButton.Text = MusicManager.MusicOn ? "Music: ON" : "Music: OFF";

            // Set SavedMusicSetting to the real current setting
            SavedMusicSetting = MusicManager.MusicOn;

            // Button styling
            AttachButtonEffects(saveButton, Color.FromArgb(30, 30, 30), Color.Gold);
            AttachButtonEffects(musicToggleButton, Color.FromArgb(30, 30, 30), Color.Gold);
            AttachButtonEffects(backButton, Color.FromArgb(90, 0, 0), Color.DarkRed);
        }

        // ============================================================
        // SAVE BUTTON — Applies settings permanently
        // ============================================================
        private void saveButton_Click(object sender, EventArgs e)
        {
            // Save names
            P1Name = txtP1Name.Text;

            if (PlayStyleOptionForm.SelectedMode == "PVP")
                P2Name = txtP2Name.Text;
            else
                P2Name = "Bot";

            // Save music state permanently
            SavedMusicSetting = MusicManager.MusicOn;

            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Hide();
        }

        // ============================================================
        // BACK BUTTON — Cancels settings and restores original music
        // ============================================================
        private void backButton_Click(object sender, EventArgs e)
        {
            // Restore original setting
            MusicManager.Set(SavedMusicSetting);

            MainMenuForm menu = new MainMenuForm();
            menu.Show();
            this.Hide();
        }

        // ============================================================
        // MUSIC TOGGLE BUTTON — Only temporary until saved
        // ============================================================
        private void musicToggleButton_Click(object sender, EventArgs e)
        {
            MusicManager.Toggle();
            musicToggleButton.Text = MusicManager.MusicOn ? "Music: ON" : "Music: OFF";
        }

        // ============================================================
        // BUTTON FX
        // ============================================================
        private void AttachButtonEffects(Button btn, Color normalBack, Color normalBorder)
        {
            btn.MouseEnter += (s, e) =>
            {
                try { hoverSound.Play(); } catch { }
                btn.BackColor = Color.FromArgb(50, 50, 50);
                btn.FlatAppearance.BorderColor = Color.White;
            };

            btn.MouseLeave += (s, e) =>
            {
                btn.BackColor = normalBack;
                btn.FlatAppearance.BorderColor = normalBorder;
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
    }
}
