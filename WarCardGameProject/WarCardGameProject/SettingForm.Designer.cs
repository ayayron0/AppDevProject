using System.Drawing;
using System.Windows.Forms;

namespace WarCardGameProject
{
    partial class SettingForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Label lblP1;
        private System.Windows.Forms.Label lblP2;
        private System.Windows.Forms.TextBox txtP1Name;
        private System.Windows.Forms.TextBox txtP2Name;
        private System.Windows.Forms.Button musicToggleButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button backButton;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblP1 = new System.Windows.Forms.Label();
            this.lblP2 = new System.Windows.Forms.Label();
            this.txtP1Name = new System.Windows.Forms.TextBox();
            this.txtP2Name = new System.Windows.Forms.TextBox();
            this.musicToggleButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();

            this.SuspendLayout();

            // ================================================
            // FORM SETTINGS
            // ================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarCardGameProject.Properties.Resources.menu_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "SettingForm";
            this.Text = "Settings";

            // Common styling
            Color gold = Color.Gold;
            Color darkPanel = Color.FromArgb(120, 0, 0, 0);
            Font labelFont = new Font("Segoe UI", 20F, FontStyle.Bold);

            // ================================================
            // LABEL — PLAYER 1
            // ================================================
            this.lblP1.AutoSize = false;
            this.lblP1.Font = labelFont;
            this.lblP1.ForeColor = gold;
            this.lblP1.BackColor = darkPanel;
            this.lblP1.Size = new Size(300, 50);
            this.lblP1.Location = new Point(220, 150);
            this.lblP1.TextAlign = ContentAlignment.MiddleLeft;
            this.lblP1.Padding = new Padding(10, 0, 0, 0);
            this.lblP1.Text = "PLAYER 1 NAME";

            // ================================================
            // LABEL — PLAYER 2
            // ================================================
            this.lblP2.AutoSize = false;
            this.lblP2.Font = labelFont;
            this.lblP2.ForeColor = gold;
            this.lblP2.BackColor = darkPanel;
            this.lblP2.Size = new Size(300, 50);
            this.lblP2.Location = new Point(220, 230);
            this.lblP2.TextAlign = ContentAlignment.MiddleLeft;
            this.lblP2.Padding = new Padding(10, 0, 0, 0);
            this.lblP2.Text = "PLAYER 2 NAME";

            // ================================================
            // TEXTBOXES
            // ================================================
            this.txtP1Name.Font = new Font("Segoe UI", 16F);
            this.txtP1Name.BackColor = Color.FromArgb(40, 40, 40);
            this.txtP1Name.ForeColor = Color.White;
            this.txtP1Name.BorderStyle = BorderStyle.FixedSingle;
            this.txtP1Name.Location = new Point(520, 155);
            this.txtP1Name.Size = new Size(300, 36);

            this.txtP2Name.Font = new Font("Segoe UI", 16F);
            this.txtP2Name.BackColor = Color.FromArgb(40, 40, 40);
            this.txtP2Name.ForeColor = Color.White;
            this.txtP2Name.BorderStyle = BorderStyle.FixedSingle;
            this.txtP2Name.Location = new Point(520, 235);
            this.txtP2Name.Size = new Size(300, 36);

            // ================================================
            // BUTTON TEMPLATE SETUP
            // ================================================
            Color baseColor = Color.FromArgb(30, 30, 30);
            Size bigBtn = new Size(260, 55);
            Font btnFont = new Font("Segoe UI", 16F, FontStyle.Bold);

            // ================================================
            // MUSIC TOGGLE BUTTON
            // ================================================
            this.musicToggleButton.BackColor = baseColor;
            this.musicToggleButton.FlatAppearance.BorderColor = gold;
            this.musicToggleButton.FlatAppearance.BorderSize = 2;
            this.musicToggleButton.FlatStyle = FlatStyle.Flat;
            this.musicToggleButton.Font = btnFont;
            this.musicToggleButton.ForeColor = Color.White;
            this.musicToggleButton.Location = new Point(382, 310);
            this.musicToggleButton.Size = bigBtn;
            this.musicToggleButton.Text = "Music: ON";
            this.musicToggleButton.Click += new System.EventHandler(this.musicToggleButton_Click);

            // ================================================
            // SAVE BUTTON
            // ================================================
            this.saveButton.BackColor = baseColor;
            this.saveButton.FlatAppearance.BorderColor = gold;
            this.saveButton.FlatAppearance.BorderSize = 2;
            this.saveButton.FlatStyle = FlatStyle.Flat;
            this.saveButton.Font = btnFont;
            this.saveButton.ForeColor = Color.White;
            this.saveButton.Location = new Point(382, 380);
            this.saveButton.Size = bigBtn;
            this.saveButton.Text = "SAVE SETTINGS";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);

            // ================================================
            // BACK BUTTON
            // ================================================
            this.backButton.BackColor = Color.FromArgb(90, 0, 0);
            this.backButton.FlatAppearance.BorderColor = Color.DarkRed;
            this.backButton.FlatAppearance.BorderSize = 2;
            this.backButton.FlatStyle = FlatStyle.Flat;
            this.backButton.Font = btnFont;
            this.backButton.ForeColor = Color.White;
            this.backButton.Location = new Point(382, 450);
            this.backButton.Size = bigBtn;
            this.backButton.Text = "BACK";
            this.backButton.Click += new System.EventHandler(this.backButton_Click);

            // ================================================
            // ADD CONTROLS
            // ================================================
            this.Controls.Add(this.lblP1);
            this.Controls.Add(this.lblP2);
            this.Controls.Add(this.txtP1Name);
            this.Controls.Add(this.txtP2Name);
            this.Controls.Add(this.musicToggleButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.backButton);

            this.ResumeLayout(false);
        }


        #endregion
    }
}
