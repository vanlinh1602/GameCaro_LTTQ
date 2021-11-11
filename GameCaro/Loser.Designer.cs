
namespace GameCaro
{
    partial class Loser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Loser));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.remPBox = new System.Windows.Forms.PictureBox();
            this.ramPBox = new System.Windows.Forms.PictureBox();
            this.okPBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.remPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(226, 215);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(550, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(248, 266);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // remPBox
            // 
            this.remPBox.BackColor = System.Drawing.Color.Transparent;
            this.remPBox.Image = ((System.Drawing.Image)(resources.GetObject("remPBox.Image")));
            this.remPBox.Location = new System.Drawing.Point(0, 243);
            this.remPBox.Name = "remPBox";
            this.remPBox.Size = new System.Drawing.Size(182, 243);
            this.remPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.remPBox.TabIndex = 3;
            this.remPBox.TabStop = false;
            // 
            // ramPBox
            // 
            this.ramPBox.BackColor = System.Drawing.Color.Transparent;
            this.ramPBox.Image = ((System.Drawing.Image)(resources.GetObject("ramPBox.Image")));
            this.ramPBox.Location = new System.Drawing.Point(613, 243);
            this.ramPBox.Name = "ramPBox";
            this.ramPBox.Size = new System.Drawing.Size(185, 243);
            this.ramPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ramPBox.TabIndex = 4;
            this.ramPBox.TabStop = false;
            // 
            // okPBox
            // 
            this.okPBox.BackColor = System.Drawing.Color.Transparent;
            this.okPBox.Image = ((System.Drawing.Image)(resources.GetObject("okPBox.Image")));
            this.okPBox.Location = new System.Drawing.Point(289, 414);
            this.okPBox.Name = "okPBox";
            this.okPBox.Size = new System.Drawing.Size(194, 54);
            this.okPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.okPBox.TabIndex = 5;
            this.okPBox.TabStop = false;
            this.okPBox.Click += new System.EventHandler(this.okPBox_Click);
            this.okPBox.MouseLeave += new System.EventHandler(this.okPBox_MouseLeave);
            this.okPBox.MouseHover += new System.EventHandler(this.okPBox_MouseHover);
            // 
            // Loser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(800, 480);
            this.ControlBox = false;
            this.Controls.Add(this.okPBox);
            this.Controls.Add(this.ramPBox);
            this.Controls.Add(this.remPBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Loser";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.remPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ramPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.okPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox remPBox;
        private System.Windows.Forms.PictureBox ramPBox;
        private System.Windows.Forms.PictureBox okPBox;
    }
}