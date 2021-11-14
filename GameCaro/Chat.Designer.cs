﻿
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
            this.chatDisplay = new GameCaro.CustomRTB();
            this.chatTextBox = new GameCaro.CustomRTB();
            this.sendPBox = new System.Windows.Forms.PictureBox();
            this.kaomojiPBox = new System.Windows.Forms.PictureBox();
            this.kaomojiList = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.sendPBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaomojiPBox)).BeginInit();
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
            // 
            // sendPBox
            // 
            this.sendPBox.BackColor = System.Drawing.Color.Transparent;
            this.sendPBox.Image = global::GameCaro.Properties.Resources.aiko_send_button;
            this.sendPBox.Location = new System.Drawing.Point(513, 414);
            this.sendPBox.Name = "sendPBox";
            this.sendPBox.Size = new System.Drawing.Size(85, 87);
            this.sendPBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sendPBox.TabIndex = 0;
            this.sendPBox.TabStop = false;
            this.sendPBox.Click += new System.EventHandler(this.sendPBox_Click);
            this.sendPBox.MouseLeave += new System.EventHandler(this.sendPBox_MouseLeave);
            this.sendPBox.MouseHover += new System.EventHandler(this.sendPBox_MouseHover);
            // 
            // kaomojiPBox
            // 
            this.kaomojiPBox.BackColor = System.Drawing.Color.Transparent;
            this.kaomojiPBox.Image = global::GameCaro.Properties.Resources.emoji_button;
            this.kaomojiPBox.Location = new System.Drawing.Point(525, 606);
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
            this.kaomojiList.Location = new System.Drawing.Point(350, 434);
            this.kaomojiList.Name = "kaomojiList";
            this.kaomojiList.Size = new System.Drawing.Size(185, 166);
            this.kaomojiList.TabIndex = 3;
            this.kaomojiList.UseCompatibleStateImageBehavior = false;
            this.kaomojiList.Visible = false;
            this.kaomojiList.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.kaomojiList_MouseDoubleClick);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameCaro.Properties.Resources.chat_background1;
            this.ClientSize = new System.Drawing.Size(600, 657);
            this.ControlBox = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.sendPBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kaomojiPBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private PictureBox sendPBox;
        private CustomRTB chatTextBox;
        private PictureBox kaomojiPBox;
        private ListView kaomojiList;
        public CustomRTB chatDisplay;
    }
}