namespace WarCardGameProject
{
    partial class PlayStyleOptionForm
    {
        private System.ComponentModel.IContainer components = null;

        private System.Windows.Forms.Panel modePanel;
        private System.Windows.Forms.Panel roundPanel;

        private System.Windows.Forms.Label modeLabel;
        private System.Windows.Forms.Label roundLabel;

        private System.Windows.Forms.RadioButton pvpButton;
        private System.Windows.Forms.RadioButton pvbButton;

        private System.Windows.Forms.RadioButton fiveRounds;
        private System.Windows.Forms.RadioButton tenRounds;
        private System.Windows.Forms.RadioButton fifteenRounds;

        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button backButton;


        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }


        #region Designer Code

        private void InitializeComponent()
        {
            this.modePanel = new System.Windows.Forms.Panel();
            this.modeLabel = new System.Windows.Forms.Label();
            this.pvpButton = new System.Windows.Forms.RadioButton();
            this.pvbButton = new System.Windows.Forms.RadioButton();
            this.roundPanel = new System.Windows.Forms.Panel();
            this.roundLabel = new System.Windows.Forms.Label();
            this.fiveRounds = new System.Windows.Forms.RadioButton();
            this.tenRounds = new System.Windows.Forms.RadioButton();
            this.fifteenRounds = new System.Windows.Forms.RadioButton();
            this.startButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.modePanel.SuspendLayout();
            this.roundPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // modePanel
            // 
            this.modePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.modePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.modePanel.Controls.Add(this.modeLabel);
            this.modePanel.Controls.Add(this.pvpButton);
            this.modePanel.Controls.Add(this.pvbButton);
            this.modePanel.Location = new System.Drawing.Point(262, 120);
            this.modePanel.Name = "modePanel";
            this.modePanel.Size = new System.Drawing.Size(500, 130);
            this.modePanel.TabIndex = 0;
            // 
            // modeLabel
            // 
            this.modeLabel.BackColor = System.Drawing.Color.Transparent;
            this.modeLabel.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modeLabel.ForeColor = System.Drawing.Color.Gold;
            this.modeLabel.Location = new System.Drawing.Point(0, 5);
            this.modeLabel.Name = "modeLabel";
            this.modeLabel.Size = new System.Drawing.Size(500, 50);
            this.modeLabel.TabIndex = 0;
            this.modeLabel.Text = "Select Game Mode";
            this.modeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pvpButton
            // 
            this.pvpButton.AutoSize = true;
            this.pvpButton.BackColor = System.Drawing.Color.Transparent;
            this.pvpButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.pvpButton.ForeColor = System.Drawing.Color.White;
            this.pvpButton.Location = new System.Drawing.Point(60, 75);
            this.pvpButton.Name = "pvpButton";
            this.pvpButton.Size = new System.Drawing.Size(195, 34);
            this.pvpButton.TabIndex = 1;
            this.pvpButton.Text = "Player vs Player";
            this.pvpButton.UseVisualStyleBackColor = false;
            // 
            // pvbButton
            // 
            this.pvbButton.AutoSize = true;
            this.pvbButton.BackColor = System.Drawing.Color.Transparent;
            this.pvbButton.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.pvbButton.ForeColor = System.Drawing.Color.White;
            this.pvbButton.Location = new System.Drawing.Point(280, 75);
            this.pvbButton.Name = "pvbButton";
            this.pvbButton.Size = new System.Drawing.Size(166, 34);
            this.pvbButton.TabIndex = 2;
            this.pvbButton.Text = "Player vs Bot";
            this.pvbButton.UseVisualStyleBackColor = false;
            // 
            // roundPanel
            // 
            this.roundPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.roundPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.roundPanel.Controls.Add(this.roundLabel);
            this.roundPanel.Controls.Add(this.fiveRounds);
            this.roundPanel.Controls.Add(this.tenRounds);
            this.roundPanel.Controls.Add(this.fifteenRounds);
            this.roundPanel.Location = new System.Drawing.Point(262, 280);
            this.roundPanel.Name = "roundPanel";
            this.roundPanel.Size = new System.Drawing.Size(500, 130);
            this.roundPanel.TabIndex = 1;
            // 
            // roundLabel
            // 
            this.roundLabel.BackColor = System.Drawing.Color.Transparent;
            this.roundLabel.Font = new System.Drawing.Font("Snap ITC", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.Gold;
            this.roundLabel.Location = new System.Drawing.Point(0, 5);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(500, 50);
            this.roundLabel.TabIndex = 0;
            this.roundLabel.Text = "Select Number of Rounds";
            this.roundLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // fiveRounds
            // 
            this.fiveRounds.AutoSize = true;
            this.fiveRounds.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.fiveRounds.ForeColor = System.Drawing.Color.White;
            this.fiveRounds.Location = new System.Drawing.Point(70, 75);
            this.fiveRounds.Name = "fiveRounds";
            this.fiveRounds.Size = new System.Drawing.Size(44, 34);
            this.fiveRounds.TabIndex = 1;
            this.fiveRounds.Text = "5";
            // 
            // tenRounds
            // 
            this.tenRounds.AutoSize = true;
            this.tenRounds.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.tenRounds.ForeColor = System.Drawing.Color.White;
            this.tenRounds.Location = new System.Drawing.Point(225, 75);
            this.tenRounds.Name = "tenRounds";
            this.tenRounds.Size = new System.Drawing.Size(57, 34);
            this.tenRounds.TabIndex = 2;
            this.tenRounds.Text = "10";
            // 
            // fifteenRounds
            // 
            this.fifteenRounds.AutoSize = true;
            this.fifteenRounds.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.fifteenRounds.ForeColor = System.Drawing.Color.White;
            this.fifteenRounds.Location = new System.Drawing.Point(380, 75);
            this.fifteenRounds.Name = "fifteenRounds";
            this.fifteenRounds.Size = new System.Drawing.Size(57, 34);
            this.fifteenRounds.TabIndex = 3;
            this.fifteenRounds.Text = "15";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.startButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.startButton.FlatAppearance.BorderSize = 2;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(300, 440);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(200, 60);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "START";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.DarkRed;
            this.backButton.FlatAppearance.BorderSize = 2;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(525, 440);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(200, 60);
            this.backButton.TabIndex = 3;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // PlayStyleOptionForm
            // 
            this.BackgroundImage = global::WarCardGameProject.Properties.Resources.menu_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 576);
            this.Controls.Add(this.modePanel);
            this.Controls.Add(this.roundPanel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "PlayStyleOptionForm";
            this.Text = "Game Options";
            this.Load += new System.EventHandler(this.PlayStyleOptionForm_Load);
            this.modePanel.ResumeLayout(false);
            this.modePanel.PerformLayout();
            this.roundPanel.ResumeLayout(false);
            this.roundPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
