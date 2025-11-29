namespace WarCardGameProject
{
    partial class InfoForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox logoPicture;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label namesLabel;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InfoForm));
            this.backButton = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.logoPicture = new System.Windows.Forms.PictureBox();
            this.infoLabel = new System.Windows.Forms.Label();
            this.namesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.backButton.FlatAppearance.BorderColor = System.Drawing.Color.Gold;
            this.backButton.FlatAppearance.BorderSize = 2;
            this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backButton.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.backButton.ForeColor = System.Drawing.Color.White;
            this.backButton.Location = new System.Drawing.Point(30, 500);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(150, 45);
            this.backButton.TabIndex = 0;
            this.backButton.Text = "BACK";
            this.backButton.UseVisualStyleBackColor = false;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Transparent;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold);
            this.titleLabel.ForeColor = System.Drawing.Color.Gold;
            this.titleLabel.Location = new System.Drawing.Point(0, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1024, 70);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "ABOUT";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // logoPicture
            // 
            this.logoPicture.BackColor = System.Drawing.Color.Transparent;
            this.logoPicture.Image = global::WarCardGameProject.Properties.Resources.cegep_logo;
            this.logoPicture.Location = new System.Drawing.Point(362, 377);
            this.logoPicture.Name = "logoPicture";
            this.logoPicture.Size = new System.Drawing.Size(300, 170);
            this.logoPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoPicture.TabIndex = 5;
            this.logoPicture.TabStop = false;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(82, 99);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(860, 274);
            this.infoLabel.TabIndex = 3;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // namesLabel
            // 
            this.namesLabel.BackColor = System.Drawing.Color.Transparent;
            this.namesLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.namesLabel.ForeColor = System.Drawing.Color.Gold;
            this.namesLabel.Location = new System.Drawing.Point(20, 550);
            this.namesLabel.Name = "namesLabel";
            this.namesLabel.Size = new System.Drawing.Size(1000, 30);
            this.namesLabel.TabIndex = 4;
            this.namesLabel.Text = "Developed by: Aaron Hossain, Arend Markies, Ehsan Hussain\r\n\r\n\r\n";
            this.namesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // InfoForm
            // 
            this.BackgroundImage = global::WarCardGameProject.Properties.Resources.info_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.namesLabel);
            this.Controls.Add(this.infoLabel);
            this.Controls.Add(this.logoPicture);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.backButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "InfoForm";
            this.Text = "About";
            ((System.ComponentModel.ISupportInitialize)(this.logoPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
    }
}
