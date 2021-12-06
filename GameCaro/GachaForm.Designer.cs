
namespace GameCaro
{
    partial class GachaForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GachaForm));
            this.MessOpen = new System.Windows.Forms.Label();
            this.OpenBTN = new System.Windows.Forms.PictureBox();
            this.Character = new System.Windows.Forms.PictureBox();
            this.Chest = new System.Windows.Forms.PictureBox();
            this.DoneBTN = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.OpenBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneBTN)).BeginInit();
            this.SuspendLayout();
            // 
            // MessOpen
            // 
            this.MessOpen.AutoSize = true;
            this.MessOpen.BackColor = System.Drawing.Color.Transparent;
            this.MessOpen.Font = new System.Drawing.Font("Segoe Print", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MessOpen.Location = new System.Drawing.Point(58, 309);
            this.MessOpen.Name = "MessOpen";
            this.MessOpen.Size = new System.Drawing.Size(250, 54);
            this.MessOpen.TabIndex = 1;
            this.MessOpen.Text = "Tap To Open!!!";
            this.MessOpen.Visible = false;
            // 
            // OpenBTN
            // 
            this.OpenBTN.BackColor = System.Drawing.Color.Transparent;
            this.OpenBTN.BackgroundImage = global::GameCaro.Properties.Resources.OpenBTN;
            this.OpenBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.OpenBTN.Location = new System.Drawing.Point(430, 105);
            this.OpenBTN.Name = "OpenBTN";
            this.OpenBTN.Size = new System.Drawing.Size(148, 62);
            this.OpenBTN.TabIndex = 2;
            this.OpenBTN.TabStop = false;
            this.OpenBTN.Click += new System.EventHandler(this.OpenBTN_Click);
            // 
            // Character
            // 
            this.Character.BackColor = System.Drawing.Color.Transparent;
            this.Character.Location = new System.Drawing.Point(90, 12);
            this.Character.Name = "Character";
            this.Character.Size = new System.Drawing.Size(181, 167);
            this.Character.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Character.TabIndex = 3;
            this.Character.TabStop = false;
            this.Character.Visible = false;
            // 
            // Chest
            // 
            this.Chest.BackColor = System.Drawing.Color.Transparent;
            this.Chest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chest.Enabled = false;
            this.Chest.Image = global::GameCaro.Properties.Resources.CloseChest;
            this.Chest.Location = new System.Drawing.Point(39, 68);
            this.Chest.Name = "Chest";
            this.Chest.Size = new System.Drawing.Size(281, 238);
            this.Chest.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Chest.TabIndex = 0;
            this.Chest.TabStop = false;
            this.Chest.Click += new System.EventHandler(this.Chest_Click);
            // 
            // DoneBTN
            // 
            this.DoneBTN.BackColor = System.Drawing.Color.Transparent;
            this.DoneBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DoneBTN.BackgroundImage")));
            this.DoneBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DoneBTN.Location = new System.Drawing.Point(430, 28);
            this.DoneBTN.Name = "DoneBTN";
            this.DoneBTN.Size = new System.Drawing.Size(148, 59);
            this.DoneBTN.TabIndex = 4;
            this.DoneBTN.TabStop = false;
            this.DoneBTN.Click += new System.EventHandler(this.DoneBTN_Click);
            // 
            // GachaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(647, 377);
            this.Controls.Add(this.DoneBTN);
            this.Controls.Add(this.Character);
            this.Controls.Add(this.OpenBTN);
            this.Controls.Add(this.MessOpen);
            this.Controls.Add(this.Chest);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GachaForm";
            this.Text = "Gacha";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GachaForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.OpenBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Character)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DoneBTN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MessOpen;
        private System.Windows.Forms.PictureBox OpenBTN;
        private System.Windows.Forms.PictureBox Character;
        private System.Windows.Forms.PictureBox Chest;
        private System.Windows.Forms.PictureBox DoneBTN;
    }
}