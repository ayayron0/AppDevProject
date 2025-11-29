using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace WarCardGameProject
{
    public partial class MainMenuForm : Form
    {
        // Sound effects
        private SoundPlayer hoverSound;
        private SoundPlayer clickSound;

        public MainMenuForm()
        {
            InitializeComponent();

            // REMOVE MUSIC HERE - Music now starts only in Program.cs

            hoverSound = new SoundPlayer(Properties.Resources.hover);
            clickSound = new SoundPlayer(Properties.Resources.click);

            AttachButtonEffects(playButton,
                Color.FromArgb(30, 30, 30), Color.Gold);

            AttachButtonEffects(aboutButton,
                Color.FromArgb(30, 30, 30), Color.Gold);

            AttachButtonEffects(settingButton,
                Color.FromArgb(30, 30, 30), Color.Gold);

            AttachButtonEffects(exitButton,
                Color.FromArgb(90, 0, 0), Color.DarkRed);   

        }

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


        private void playButton_Click(object sender, EventArgs e)
        {
            PlayStyleOptionForm form = new PlayStyleOptionForm();
            form.Show();
            this.Hide();
        }

        private void aboutButton_Click(object sender, EventArgs e)
        {
            InfoForm form = new InfoForm();
            form.Show();
            this.Hide();
        }

        private void settingButton_Click(object sender, EventArgs e)
        {
            SettingForm form = new SettingForm();
            form.Show();
            this.Hide();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
