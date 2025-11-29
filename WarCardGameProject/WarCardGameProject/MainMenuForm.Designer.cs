namespace WarCardGameProject
{
    partial class MainMenuForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button aboutButton;
        private System.Windows.Forms.Button settingButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.PictureBox titlePicture;

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
            this.playButton = new System.Windows.Forms.Button();
            this.aboutButton = new System.Windows.Forms.Button();
            this.settingButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.titlePicture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.playButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.playButton.FlatAppearance.BorderSize = 2;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.playButton.ForeColor = System.Drawing.Color.White;
            this.playButton.Location = new System.Drawing.Point(382, 270);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(260, 55);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // aboutButton
            // 
            this.aboutButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.aboutButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.aboutButton.FlatAppearance.BorderSize = 2;
            this.aboutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.aboutButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.aboutButton.ForeColor = System.Drawing.Color.White;
            this.aboutButton.Location = new System.Drawing.Point(382, 340);
            this.aboutButton.Name = "aboutButton";
            this.aboutButton.Size = new System.Drawing.Size(260, 55);
            this.aboutButton.TabIndex = 2;
            this.aboutButton.Text = "ABOUT";
            this.aboutButton.UseVisualStyleBackColor = false;
            this.aboutButton.Click += new System.EventHandler(this.aboutButton_Click);
            // 
            // settingButton
            // 
            this.settingButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.settingButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.settingButton.FlatAppearance.BorderSize = 2;
            this.settingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.settingButton.ForeColor = System.Drawing.Color.White;
            this.settingButton.Location = new System.Drawing.Point(382, 410);
            this.settingButton.Name = "settingButton";
            this.settingButton.Size = new System.Drawing.Size(260, 55);
            this.settingButton.TabIndex = 3;
            this.settingButton.Text = "SETTINGS";
            this.settingButton.UseVisualStyleBackColor = false;
            this.settingButton.Click += new System.EventHandler(this.settingButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.exitButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.exitButton.FlatAppearance.BorderSize = 2;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.exitButton.ForeColor = System.Drawing.Color.White;
            this.exitButton.Location = new System.Drawing.Point(382, 480);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(260, 55);
            this.exitButton.TabIndex = 4;
            this.exitButton.Text = "EXIT";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // titlePicture
            // 
            this.titlePicture.BackColor = System.Drawing.Color.Transparent;
            this.titlePicture.Image = global::WarCardGameProject.Properties.Resources.title;
            this.titlePicture.Location = new System.Drawing.Point(112, 12);
            this.titlePicture.Name = "titlePicture";
            this.titlePicture.Size = new System.Drawing.Size(800, 250);
            this.titlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlePicture.TabIndex = 100;
            this.titlePicture.TabStop = false;
            // 
            // MainMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarCardGameProject.Properties.Resources.menu_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.titlePicture);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.aboutButton);
            this.Controls.Add(this.settingButton);
            this.Controls.Add(this.exitButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "MainMenuForm";
            this.Text = "War: Card Game";
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
