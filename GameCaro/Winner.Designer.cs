
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
            this.rikkaPbox = new System.Windows.Forms.PictureBox();
            this.fireworkPBox = new System.Windows.Forms.PictureBox();
            this.okPBox = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.rikkaPbox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireworkPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // rikkaPbox
            // 
            this.rikkaPbox.BackColor = System.Drawing.Color.Transparent;
            this.rikkaPbox.Image = ((System.Drawing.Image)(resources.GetObject("rikkaPbox.Image")));
            this.rikkaPbox.Location = new System.Drawing.Point(267, 189);
            this.rikkaPbox.Name = "rikkaPbox";
            this.rikkaPbox.Size = new System.Drawing.Size(260, 297);
            this.rikkaPbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.rikkaPbox.TabIndex = 0;
            this.rikkaPbox.TabStop = false;
            // 
            // fireworkPBox
            // 
            this.fireworkPBox.BackColor = System.Drawing.Color.Transparent;
            this.fireworkPBox.Image = ((System.Drawing.Image)(resources.GetObject("fireworkPBox.Image")));
            this.fireworkPBox.Location = new System.Drawing.Point(-1, -2);
            this.fireworkPBox.Name = "fireworkPBox";
            this.fireworkPBox.Size = new System.Drawing.Size(149, 149);
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
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(652, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(149, 149);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
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
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.fireworkPBox);
            this.Controls.Add(this.rikkaPbox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Winner";
            ((System.ComponentModel.ISupportInitialize)(this.rikkaPbox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fireworkPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox rikkaPbox;
        private System.Windows.Forms.PictureBox fireworkPBox;
        private System.Windows.Forms.PictureBox okPBox;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}