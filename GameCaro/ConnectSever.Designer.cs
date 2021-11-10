
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
            this.TbIP = new System.Windows.Forms.TextBox();
            this.PBConnect = new System.Windows.Forms.PictureBox();
            this.PBCreate = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PBConnect)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCreate)).BeginInit();
            this.SuspendLayout();
            // 
            // TbIP
            // 
            this.TbIP.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TbIP.Location = new System.Drawing.Point(167, 128);
            this.TbIP.Name = "TbIP";
            this.TbIP.Size = new System.Drawing.Size(245, 45);
            this.TbIP.TabIndex = 1;
            // 
            // PBConnect
            // 
            this.PBConnect.BackColor = System.Drawing.Color.Transparent;
            this.PBConnect.BackgroundImage = global::GameCaro.Properties.Resources.ConnectBTN;
            this.PBConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBConnect.Location = new System.Drawing.Point(120, 224);
            this.PBConnect.Name = "PBConnect";
            this.PBConnect.Size = new System.Drawing.Size(87, 38);
            this.PBConnect.TabIndex = 2;
            this.PBConnect.TabStop = false;
            this.PBConnect.Click += new System.EventHandler(this.PBConnect_Click);
            // 
            // PBCreate
            // 
            this.PBCreate.BackColor = System.Drawing.Color.Transparent;
            this.PBCreate.BackgroundImage = global::GameCaro.Properties.Resources.CreateBTN;
            this.PBCreate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PBCreate.Location = new System.Drawing.Point(263, 224);
            this.PBCreate.Name = "PBCreate";
            this.PBCreate.Size = new System.Drawing.Size(87, 38);
            this.PBCreate.TabIndex = 3;
            this.PBCreate.TabStop = false;
            this.PBCreate.Click += new System.EventHandler(this.PBCreate_Click);
            // 
            // ConnectSever
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameCaro.Properties.Resources.BackgroudConnect;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(468, 303);
            this.ControlBox = false;
            this.Controls.Add(this.PBCreate);
            this.Controls.Add(this.PBConnect);
            this.Controls.Add(this.TbIP);
            this.Name = "ConnectSever";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Connect";
            ((System.ComponentModel.ISupportInitialize)(this.PBConnect)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBCreate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox TbIP;
        private System.Windows.Forms.PictureBox PBConnect;
        private System.Windows.Forms.PictureBox PBCreate;
    }
}