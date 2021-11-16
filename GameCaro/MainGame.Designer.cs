
namespace GameCaro
{
    partial class MainGame
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainGame));
            this.Chess_Board = new System.Windows.Forms.Panel();
            this.PointLayer1 = new System.Windows.Forms.Label();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.PointLayer2 = new System.Windows.Forms.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PbSurrender = new System.Windows.Forms.PictureBox();
            this.PbQuit = new System.Windows.Forms.PictureBox();
            this.PbChat = new System.Windows.Forms.PictureBox();
            this.PbNewGame = new System.Windows.Forms.PictureBox();
            this.AvatarPlayer1 = new System.Windows.Forms.PictureBox();
            this.AvatarPlayer2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PbSurrender)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbQuit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbChat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNewGame)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPlayer1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPlayer2)).BeginInit();
            this.SuspendLayout();
            // 
            // Chess_Board
            // 
            this.Chess_Board.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Chess_Board.BackgroundImage")));
            this.Chess_Board.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Chess_Board.Location = new System.Drawing.Point(270, 12);
            this.Chess_Board.Name = "Chess_Board";
            this.Chess_Board.Size = new System.Drawing.Size(839, 603);
            this.Chess_Board.TabIndex = 0;
            // 
            // PointLayer1
            // 
            this.PointLayer1.BackColor = System.Drawing.Color.Transparent;
            this.PointLayer1.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PointLayer1.Location = new System.Drawing.Point(95, 563);
            this.PointLayer1.Name = "PointLayer1";
            this.PointLayer1.Size = new System.Drawing.Size(85, 79);
            this.PointLayer1.TabIndex = 5;
            this.PointLayer1.Text = "0";
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::GameCaro.Properties.Resources.anime_happy;
            this.pictureBox4.Location = new System.Drawing.Point(12, 322);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(221, 161);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // PointLayer2
            // 
            this.PointLayer2.BackColor = System.Drawing.Color.Transparent;
            this.PointLayer2.Font = new System.Drawing.Font("Stencil", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PointLayer2.Location = new System.Drawing.Point(1213, 563);
            this.PointLayer2.Name = "PointLayer2";
            this.PointLayer2.Size = new System.Drawing.Size(85, 79);
            this.PointLayer2.TabIndex = 5;
            this.PointLayer2.Text = "0";
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::GameCaro.Properties.Resources.anime_happy;
            this.pictureBox7.Location = new System.Drawing.Point(1141, 322);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(221, 161);
            this.pictureBox7.TabIndex = 3;
            this.pictureBox7.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.PbSurrender);
            this.panel3.Controls.Add(this.PbQuit);
            this.panel3.Controls.Add(this.PbChat);
            this.panel3.Controls.Add(this.PbNewGame);
            this.panel3.Location = new System.Drawing.Point(360, 621);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(644, 76);
            this.panel3.TabIndex = 7;
            // 
            // PbSurrender
            // 
            this.PbSurrender.BackgroundImage = global::GameCaro.Properties.Resources.DauHang;
            this.PbSurrender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbSurrender.Location = new System.Drawing.Point(363, 0);
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
            this.PbQuit.Location = new System.Drawing.Point(525, 0);
            this.PbQuit.Name = "PbQuit";
            this.PbQuit.Size = new System.Drawing.Size(70, 70);
            this.PbQuit.TabIndex = 2;
            this.PbQuit.TabStop = false;
            this.PbQuit.Click += new System.EventHandler(this.PbQuit_Click);
            // 
            // PbChat
            // 
            this.PbChat.BackgroundImage = global::GameCaro.Properties.Resources.CHAT2;
            this.PbChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbChat.Location = new System.Drawing.Point(205, 0);
            this.PbChat.Name = "PbChat";
            this.PbChat.Size = new System.Drawing.Size(70, 70);
            this.PbChat.TabIndex = 1;
            this.PbChat.TabStop = false;
            this.PbChat.Click += new System.EventHandler(this.PbChat_Click);
            // 
            // PbNewGame
            // 
            this.PbNewGame.BackgroundImage = global::GameCaro.Properties.Resources.New_game;
            this.PbNewGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PbNewGame.Location = new System.Drawing.Point(54, 0);
            this.PbNewGame.Name = "PbNewGame";
            this.PbNewGame.Size = new System.Drawing.Size(70, 70);
            this.PbNewGame.TabIndex = 0;
            this.PbNewGame.TabStop = false;
            this.PbNewGame.Click += new System.EventHandler(this.PbNewGame_Click);
            // 
            // AvatarPlayer1
            // 
            this.AvatarPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.AvatarPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AvatarPlayer1.Location = new System.Drawing.Point(24, 21);
            this.AvatarPlayer1.Name = "AvatarPlayer1";
            this.AvatarPlayer1.Size = new System.Drawing.Size(209, 161);
            this.AvatarPlayer1.TabIndex = 0;
            this.AvatarPlayer1.TabStop = false;
            // 
            // AvatarPlayer2
            // 
            this.AvatarPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.AvatarPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.AvatarPlayer2.Location = new System.Drawing.Point(1141, 21);
            this.AvatarPlayer2.Name = "AvatarPlayer2";
            this.AvatarPlayer2.Size = new System.Drawing.Size(211, 161);
            this.AvatarPlayer2.TabIndex = 8;
            this.AvatarPlayer2.TabStop = false;
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameCaro.Properties.Resources.BGMainGame;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1374, 697);
            this.ControlBox = false;
            this.Controls.Add(this.AvatarPlayer2);
            this.Controls.Add(this.AvatarPlayer1);
            this.Controls.Add(this.PointLayer2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.PointLayer1);
            this.Controls.Add(this.Chess_Board);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GameCaro";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PbSurrender)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbQuit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbChat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbNewGame)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPlayer1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvatarPlayer2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel Chess_Board;
        private System.Windows.Forms.Label PointLayer1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label PointLayer2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox PbSurrender;
        private System.Windows.Forms.PictureBox PbQuit;
        private System.Windows.Forms.PictureBox PbChat;
        private System.Windows.Forms.PictureBox PbNewGame;
        private System.Windows.Forms.PictureBox AvatarPlayer1;
        private System.Windows.Forms.PictureBox AvatarPlayer2;
    }
}

