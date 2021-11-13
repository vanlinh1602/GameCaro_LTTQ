
namespace GameCaro
{
    partial class Exit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exit));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SurePB = new System.Windows.Forms.PictureBox();
            this.CancelPB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPB)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(540, 432);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // SurePB
            // 
            this.SurePB.BackColor = System.Drawing.Color.Transparent;
            this.SurePB.BackgroundImage = global::GameCaro.Properties.Resources.SureBTN;
            this.SurePB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SurePB.Location = new System.Drawing.Point(68, 357);
            this.SurePB.Name = "SurePB";
            this.SurePB.Size = new System.Drawing.Size(158, 62);
            this.SurePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.SurePB.TabIndex = 1;
            this.SurePB.TabStop = false;
            this.SurePB.Click += new System.EventHandler(this.SurePB_Click);
            // 
            // CancelPB
            // 
            this.CancelPB.BackColor = System.Drawing.Color.Transparent;
            this.CancelPB.BackgroundImage = global::GameCaro.Properties.Resources.CancelBTN;
            this.CancelPB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelPB.Location = new System.Drawing.Point(305, 357);
            this.CancelPB.Name = "CancelPB";
            this.CancelPB.Size = new System.Drawing.Size(158, 62);
            this.CancelPB.TabIndex = 2;
            this.CancelPB.TabStop = false;
            this.CancelPB.Click += new System.EventHandler(this.CancelPB_Click);
            // 
            // Exit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(539, 431);
            this.Controls.Add(this.CancelPB);
            this.Controls.Add(this.SurePB);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Exit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SurePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelPB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox SurePB;
        private System.Windows.Forms.PictureBox CancelPB;
    }
}