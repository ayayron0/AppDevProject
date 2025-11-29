using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace WarCardGameProject
{
    public partial class InfoForm : Form
    {
        private SoundPlayer hoverSound;
        private SoundPlayer clickSound;

        public InfoForm()
        {
            InitializeComponent();

            hoverSound = new SoundPlayer(Properties.Resources.hover);
            clickSound = new SoundPlayer(Properties.Resources.click);

            AttachButtonEffects(backButton);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            MainMenuForm menu = new MainMenuForm();
            menu.Show();
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
                btn.BackColor = Color.FromArgb(30, 30, 30);
                btn.FlatAppearance.BorderColor = Color.Gold;
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
