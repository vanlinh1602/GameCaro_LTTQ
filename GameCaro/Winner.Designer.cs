
namespace GameCaro
{
    partial class Winner
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Winner));
            this.centerPbox = new System.Windows.Forms.PictureBox();
            this.fireworkPBox = new System.Windows.Forms.PictureBox();
            this.okPBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.centerPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireworkPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // centerPbox
            // 
            this.centerPbox.BackColor = System.Drawing.Color.Transparent;
            this.centerPbox.Image = ((System.Drawing.Image)(resources.GetObject("centerPbox.Image")));
            this.centerPbox.Location = new System.Drawing.Point(57, 171);
            this.centerPbox.Name = "centerPbox";
            this.centerPbox.Size = new System.Drawing.Size(472, 357);
            this.centerPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.centerPbox.TabIndex = 0;
            this.centerPbox.TabStop = false;
            // 
            // fireworkPBox
            // 
            this.fireworkPBox.BackColor = System.Drawing.Color.Transparent;
            this.fireworkPBox.Image = ((System.Drawing.Image)(resources.GetObject("fireworkPBox.Image")));
            this.fireworkPBox.Location = new System.Drawing.Point(-1, -2);
            this.fireworkPBox.Name = "fireworkPBox";
            this.fireworkPBox.Size = new System.Drawing.Size(200, 199);
            this.fireworkPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fireworkPBox.TabIndex = 1;
            this.fireworkPBox.TabStop = false;
            // 
            // okPBox
            // 
            this.okPBox.BackColor = System.Drawing.Color.Transparent;
            this.okPBox.Image = ((System.Drawing.Image)(resources.GetObject("okPBox.Image")));
            this.okPBox.Location = new System.Drawing.Point(267, 492);
            this.okPBox.Name = "okPBox";
            this.okPBox.Size = new System.Drawing.Size(244, 73);
            this.okPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.okPBox.TabIndex = 2;
            this.okPBox.TabStop = false;
            this.okPBox.Click += new System.EventHandler(this.okPBox_Click);
            this.okPBox.MouseLeave += new System.EventHandler(this.okPBox_MouseLeave);
            this.okPBox.MouseHover += new System.EventHandler(this.okPBox_MouseHover);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(602, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 199);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Winner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.ControlBox = false;
            this.Controls.Add(this.okPBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.fireworkPBox);
            this.Controls.Add(this.centerPbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Winner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.centerPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireworkPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox centerPbox;
        private System.Windows.Forms.PictureBox fireworkPBox;
        private System.Windows.Forms.PictureBox okPBox;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}