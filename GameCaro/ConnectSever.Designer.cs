
namespace GameCaro
{
    partial class ConnectSever
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectSever));
            this.TbIP = new System.Windows.Forms.TextBox();
            this.PBConnect = new System.Windows.Forms.PictureBox();
            this.PBCreate = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.TbName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCreate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TbIP
            // 
            this.TbIP.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbIP.Location = new System.Drawing.Point(203, 166);
            this.TbIP.Name = "TbIP";
            this.TbIP.Size = new System.Drawing.Size(245, 45);
            this.TbIP.TabIndex = 1;
            // 
            // PBConnect
            // 
            this.PBConnect.BackColor = System.Drawing.Color.Transparent;
            this.PBConnect.BackgroundImage = global::GameCaro.Properties.Resources.ConnectBTN;
            this.PBConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBConnect.Location = new System.Drawing.Point(99, 228);
            this.PBConnect.Name = "PBConnect";
            this.PBConnect.Size = new System.Drawing.Size(113, 47);
            this.PBConnect.TabIndex = 2;
            this.PBConnect.TabStop = false;
            this.PBConnect.Click += new System.EventHandler(this.PBConnect_Click);
            // 
            // PBCreate
            // 
            this.PBCreate.BackColor = System.Drawing.Color.Transparent;
            this.PBCreate.BackgroundImage = global::GameCaro.Properties.Resources.CreateBTN;
            this.PBCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBCreate.Location = new System.Drawing.Point(295, 228);
            this.PBCreate.Name = "PBCreate";
            this.PBCreate.Size = new System.Drawing.Size(117, 47);
            this.PBCreate.TabIndex = 3;
            this.PBCreate.TabStop = false;
            this.PBCreate.Click += new System.EventHandler(this.PBCreate_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::GameCaro.Properties.Resources.CloseBTN;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(203, 281);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(107, 47);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // TbName
            // 
            this.TbName.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbName.Location = new System.Drawing.Point(203, 108);
            this.TbName.Name = "TbName";
            this.TbName.Size = new System.Drawing.Size(245, 45);
            this.TbName.TabIndex = 5;
            // 
            // ConnectSever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(521, 340);
            this.ControlBox = false;
            this.Controls.Add(this.TbName);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.PBCreate);
            this.Controls.Add(this.PBConnect);
            this.Controls.Add(this.TbIP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "ConnectSever";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect";
            ((System.ComponentModel.ISupportInitialize)(this.PBConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCreate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbIP;
        private System.Windows.Forms.PictureBox PBConnect;
        private System.Windows.Forms.PictureBox PBCreate;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox TbName;
    }
}