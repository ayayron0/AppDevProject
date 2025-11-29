namespace WarCardGameProject
{
    partial class EndForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.restartButton = new System.Windows.Forms.Button();
            this.returnButton = new System.Windows.Forms.Button();
            this.titlePicture = new System.Windows.Forms.PictureBox();
            this.modePanel = new System.Windows.Forms.Panel();
            this.statusLabel = new System.Windows.Forms.Label();
            this.scorelabel = new System.Windows.Forms.Label();
            this.p1ScoreLabel = new System.Windows.Forms.Label();
            this.p2ScoreLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).BeginInit();
            this.modePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.restartButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.restartButton.FlatAppearance.BorderSize = 2;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.restartButton.ForeColor = System.Drawing.Color.White;
            this.restartButton.Location = new System.Drawing.Point(342, 448);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(346, 55);
            this.restartButton.TabIndex = 2;
            this.restartButton.Text = "RESTART";
            this.restartButton.UseVisualStyleBackColor = false;
            // 
            // returnButton
            // 
            this.returnButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.returnButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.returnButton.FlatAppearance.BorderSize = 2;
            this.returnButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.returnButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.returnButton.ForeColor = System.Drawing.Color.White;
            this.returnButton.Location = new System.Drawing.Point(342, 509);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(346, 55);
            this.returnButton.TabIndex = 102;
            this.returnButton.Text = "MAIN MENU";
            this.returnButton.UseVisualStyleBackColor = false;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // titlePicture
            // 
            this.titlePicture.BackColor = System.Drawing.Color.Transparent;
            this.titlePicture.Image = global::WarCardGameProject.Properties.Resources.title;
            this.titlePicture.Location = new System.Drawing.Point(112, 12);
            this.titlePicture.Name = "titlePicture";
            this.titlePicture.Size = new System.Drawing.Size(800, 179);
            this.titlePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.titlePicture.TabIndex = 103;
            this.titlePicture.TabStop = false;
            // 
            // modePanel
            // 
            this.modePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.modePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modePanel.Controls.Add(this.p2ScoreLabel);
            this.modePanel.Controls.Add(this.p1ScoreLabel);
            this.modePanel.Controls.Add(this.scorelabel);
            this.modePanel.Controls.Add(this.statusLabel);
            this.modePanel.Location = new System.Drawing.Point(262, 222);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(500, 200);
            this.modePanel.TabIndex = 104;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.Color.Transparent;
            this.statusLabel.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.Gold;
            this.statusLabel.Location = new System.Drawing.Point(-1, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(500, 50);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "You Win!";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // scorelabel
            // 
            this.scorelabel.BackColor = System.Drawing.Color.Transparent;
            this.scorelabel.Font = new System.Drawing.Font("Snap ITC", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scorelabel.ForeColor = System.Drawing.Color.Gold;
            this.scorelabel.Location = new System.Drawing.Point(-1, 50);
            this.scorelabel.Name = "scorelabel";
            this.scorelabel.Size = new System.Drawing.Size(500, 50);
            this.scorelabel.TabIndex = 1;
            this.scorelabel.Text = "Score";
            this.scorelabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // p1ScoreLabel
            // 
            this.p1ScoreLabel.AutoSize = true;
            this.p1ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.p1ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p1ScoreLabel.Location = new System.Drawing.Point(6, 110);
            this.p1ScoreLabel.Name = "p1ScoreLabel";
            this.p1ScoreLabel.Size = new System.Drawing.Size(103, 30);
            this.p1ScoreLabel.TabIndex = 2;
            this.p1ScoreLabel.Text = "Player 1:";
            // 
            // p2ScoreLabel
            // 
            this.p2ScoreLabel.AutoSize = true;
            this.p2ScoreLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.p2ScoreLabel.ForeColor = System.Drawing.Color.White;
            this.p2ScoreLabel.Location = new System.Drawing.Point(6, 151);
            this.p2ScoreLabel.Name = "p2ScoreLabel";
            this.p2ScoreLabel.Size = new System.Drawing.Size(103, 30);
            this.p2ScoreLabel.TabIndex = 3;
            this.p2ScoreLabel.Text = "Player 2:";
            // 
            // EndForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WarCardGameProject.Properties.Resources.menu_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.modePanel);
            this.Controls.Add(this.titlePicture);
            this.Controls.Add(this.returnButton);
            this.Controls.Add(this.restartButton);
            this.Name = "EndForm";
            this.Text = "Game Over";
            ((System.ComponentModel.ISupportInitialize)(this.titlePicture)).EndInit();
            this.modePanel.ResumeLayout(false);
            this.modePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.PictureBox titlePicture;
        private System.Windows.Forms.Panel modePanel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label scorelabel;
        private System.Windows.Forms.Label p1ScoreLabel;
        private System.Windows.Forms.Label p2ScoreLabel;
    }
}