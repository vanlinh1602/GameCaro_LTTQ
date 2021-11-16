
using System.Windows.Forms;

namespace GameCaro
{
    partial class Chat
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.chatDisplay = new GameCaro.CustomRTB();
            this.chatTextBox = new GameCaro.CustomRTB();
            this.kaomojiPBox = new System.Windows.Forms.PictureBox();
            this.kaomojiList = new System.Windows.Forms.ListView();
            this.sendPBox = new System.Windows.Forms.PictureBox();
            this.tempSendPBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kaomojiPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempSendPBox)).BeginInit();
            this.SuspendLayout();
            // 
            // chatDisplay
            // 
            this.chatDisplay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatDisplay.Enabled = false;
            this.chatDisplay.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chatDisplay.ForeColor = System.Drawing.SystemColors.Info;
            this.chatDisplay.Location = new System.Drawing.Point(148, 12);
            this.chatDisplay.Name = "chatDisplay";
            this.chatDisplay.Size = new System.Drawing.Size(387, 396);
            this.chatDisplay.TabIndex = 0;
            this.chatDisplay.Text = "";
            this.chatDisplay.TextChanged += new System.EventHandler(this.chatDisplay_TextChanged);
            // 
            // chatTextBox
            // 
            this.chatTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.chatTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.chatTextBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.chatTextBox.Location = new System.Drawing.Point(103, 546);
            this.chatTextBox.Name = "chatTextBox";
            this.chatTextBox.Size = new System.Drawing.Size(410, 99);
            this.chatTextBox.TabIndex = 1;
            this.chatTextBox.Text = "";
            this.chatTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.chatTextBox_KeyDown);
            this.chatTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.chatTextBox_KeyPress);
            // 
            // kaomojiPBox
            // 
            this.kaomojiPBox.BackColor = System.Drawing.Color.Transparent;
            this.kaomojiPBox.Image = global::GameCaro.Properties.Resources.emoji_button;
            this.kaomojiPBox.Location = new System.Drawing.Point(526, 466);
            this.kaomojiPBox.Name = "kaomojiPBox";
            this.kaomojiPBox.Size = new System.Drawing.Size(73, 39);
            this.kaomojiPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.kaomojiPBox.TabIndex = 2;
            this.kaomojiPBox.TabStop = false;
            this.kaomojiPBox.Click += new System.EventHandler(this.kaomojiPBox_Click);
            this.kaomojiPBox.MouseHover += new System.EventHandler(this.kaomojiPBox_MouseHover);
            this.kaomojiPBox.MouseMove += new System.Windows.Forms.MouseEventHandler(this.kaomojiPBox_MouseMove);
            // 
            // kaomojiList
            // 
            this.kaomojiList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.kaomojiList.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.kaomojiList.HideSelection = false;
            this.kaomojiList.Location = new System.Drawing.Point(355, 268);
            this.kaomojiList.Name = "kaomojiList";
            this.kaomojiList.Size = new System.Drawing.Size(244, 192);
            this.kaomojiList.TabIndex = 3;
            this.kaomojiList.UseCompatibleStateImageBehavior = false;
            this.kaomojiList.Visible = false;
            this.kaomojiList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.kaomojiList_MouseDoubleClick);
            // 
            // sendPBox
            // 
            this.sendPBox.BackColor = System.Drawing.Color.Transparent;
            this.sendPBox.Image = ((System.Drawing.Image)(resources.GetObject("sendPBox.Image")));
            this.sendPBox.Location = new System.Drawing.Point(545, 606);
            this.sendPBox.Name = "sendPBox";
            this.sendPBox.Size = new System.Drawing.Size(54, 54);
            this.sendPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sendPBox.TabIndex = 0;
            this.sendPBox.TabStop = false;
            this.sendPBox.Click += new System.EventHandler(this.sendPBox_Click);
            this.sendPBox.MouseLeave += new System.EventHandler(this.sendPBox_MouseLeave);
            // 
            // tempSendPBox
            // 
            this.tempSendPBox.BackColor = System.Drawing.Color.Transparent;
            this.tempSendPBox.Image = global::GameCaro.Properties.Resources.send_button_stage_11;
            this.tempSendPBox.Location = new System.Drawing.Point(545, 606);
            this.tempSendPBox.Name = "tempSendPBox";
            this.tempSendPBox.Size = new System.Drawing.Size(54, 54);
            this.tempSendPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tempSendPBox.TabIndex = 4;
            this.tempSendPBox.TabStop = false;
            this.tempSendPBox.MouseHover += new System.EventHandler(this.tempSendPBox_MouseHover);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameCaro.Properties.Resources.chat_background1;
            this.ClientSize = new System.Drawing.Size(600, 657);
            this.ControlBox = false;
            this.Controls.Add(this.tempSendPBox);
            this.Controls.Add(this.kaomojiList);
            this.Controls.Add(this.kaomojiPBox);
            this.Controls.Add(this.sendPBox);
            this.Controls.Add(this.chatTextBox);
            this.Controls.Add(this.chatDisplay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Chat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chat";
            this.Load += new System.EventHandler(this.Chat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kaomojiPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sendPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tempSendPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomRTB chatTextBox;
        private PictureBox kaomojiPBox;
        private ListView kaomojiList;
        public CustomRTB chatDisplay;
        private PictureBox sendPBox;
        private PictureBox tempSendPBox;
    }
}