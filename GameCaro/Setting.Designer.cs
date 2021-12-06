
namespace GameCaro
{
    partial class Setting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Setting));
            this.PbSurrender = new System.Windows.Forms.PictureBox();
            this.PbQuit = new System.Windows.Forms.PictureBox();
            this.HistoryBTN = new System.Windows.Forms.PictureBox();
            this.VolumeBTN = new System.Windows.Forms.PictureBox();
            this.ChangVolume = new System.Windows.Forms.Panel();
            this.UpVolume = new System.Windows.Forms.PictureBox();
            this.DownVolume = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PbSurrender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryBTN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBTN)).BeginInit();
            this.ChangVolume.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UpVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownVolume)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // PbSurrender
            // 
            this.PbSurrender.BackgroundImage = global::GameCaro.Properties.Resources.DauHang;
            this.PbSurrender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSurrender.Location = new System.Drawing.Point(13, 12);
            this.PbSurrender.Name = "PbSurrender";
            this.PbSurrender.Size = new System.Drawing.Size(70, 70);
            this.PbSurrender.TabIndex = 3;
            this.PbSurrender.TabStop = false;
            this.PbSurrender.Click += new System.EventHandler(this.PbSurrender_Click);
            // 
            // PbQuit
            // 
            this.PbQuit.BackgroundImage = global::GameCaro.Properties.Resources.quit;
            this.PbQuit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbQuit.Location = new System.Drawing.Point(95, 199);
            this.PbQuit.Name = "PbQuit";
            this.PbQuit.Size = new System.Drawing.Size(70, 70);
            this.PbQuit.TabIndex = 2;
            this.PbQuit.TabStop = false;
            this.PbQuit.Click += new System.EventHandler(this.PbQuit_Click);
            // 
            // HistoryBTN
            // 
            this.HistoryBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HistoryBTN.BackgroundImage")));
            this.HistoryBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.HistoryBTN.Location = new System.Drawing.Point(180, 12);
            this.HistoryBTN.Name = "HistoryBTN";
            this.HistoryBTN.Size = new System.Drawing.Size(70, 70);
            this.HistoryBTN.TabIndex = 1;
            this.HistoryBTN.TabStop = false;
            // 
            // VolumeBTN
            // 
            this.VolumeBTN.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VolumeBTN.BackgroundImage")));
            this.VolumeBTN.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.VolumeBTN.Location = new System.Drawing.Point(13, 103);
            this.VolumeBTN.Name = "VolumeBTN";
            this.VolumeBTN.Size = new System.Drawing.Size(70, 68);
            this.VolumeBTN.TabIndex = 0;
            this.VolumeBTN.TabStop = false;
            // 
            // ChangVolume
            // 
            this.ChangVolume.BackColor = System.Drawing.Color.Transparent;
            this.ChangVolume.Controls.Add(this.UpVolume);
            this.ChangVolume.Controls.Add(this.DownVolume);
            this.ChangVolume.Location = new System.Drawing.Point(95, 103);
            this.ChangVolume.Name = "ChangVolume";
            this.ChangVolume.Size = new System.Drawing.Size(131, 70);
            this.ChangVolume.TabIndex = 10;
            // 
            // UpVolume
            // 
            this.UpVolume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("UpVolume.BackgroundImage")));
            this.UpVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.UpVolume.Location = new System.Drawing.Point(75, 6);
            this.UpVolume.Name = "UpVolume";
            this.UpVolume.Size = new System.Drawing.Size(50, 51);
            this.UpVolume.TabIndex = 10;
            this.UpVolume.TabStop = false;
            // 
            // DownVolume
            // 
            this.DownVolume.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownVolume.BackgroundImage")));
            this.DownVolume.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DownVolume.Location = new System.Drawing.Point(3, 7);
            this.DownVolume.Name = "DownVolume";
            this.DownVolume.Size = new System.Drawing.Size(51, 51);
            this.DownVolume.TabIndex = 11;
            this.DownVolume.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(95, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(70, 70);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // Setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(263, 288);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PbQuit);
            this.Controls.Add(this.PbSurrender);
            this.Controls.Add(this.ChangVolume);
            this.Controls.Add(this.VolumeBTN);
            this.Controls.Add(this.HistoryBTN);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Setting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Setting";
            ((System.ComponentModel.ISupportInitialize)(this.PbSurrender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HistoryBTN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.VolumeBTN)).EndInit();
            this.ChangVolume.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UpVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DownVolume)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox PbSurrender;
        private System.Windows.Forms.PictureBox PbQuit;
        private System.Windows.Forms.PictureBox HistoryBTN;
        private System.Windows.Forms.PictureBox VolumeBTN;
        private System.Windows.Forms.Panel ChangVolume;
        private System.Windows.Forms.PictureBox UpVolume;
        private System.Windows.Forms.PictureBox DownVolume;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}