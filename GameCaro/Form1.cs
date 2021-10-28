using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameCaro
{
    public partial class Form1 : Form
    {
        ChessBoardManager ChessBoard;
        public Form1()
        {
            Icon = new Icon(Application.StartupPath + @"Resources\icon.ico");
            InitializeComponent();
            ChessBoard = new ChessBoardManager(Chess_Board);
            SetUpTimeDown();
            ChessBoard.EndGame += ChessBoard_EndGame;
            ChessBoard.PlayerMark += ChessBoard_PlayerMark;
            NewGame();

        }

        private void ChessBoard_PlayerMark(object sender, EventArgs e)
        {
            TimeDown.Value = 0;
            CountTime.Start();
        }
        private void ChessBoard_EndGame(object sender, EventArgs e)
        {
            EndGame();
        }
        void SetUpTimeDown()
        {
            TimeDown.Step = GameManager.Process_Step;
            TimeDown.Maximum = GameManager.Process_Maximun;
            CountTime.Interval = GameManager.Timer_Interval;
        }
        private void CountTime_Tick(object sender, EventArgs e)
        {
            TimeDown.PerformStep();
            if (TimeDown.Value >= GameManager.Process_Maximun)
            {
                EndGame();
            }
        }
        private void EndGame()
        {
            CountTime.Stop();
            MessageBox.Show("End Game! Good job Bro");
            Chess_Board.Enabled = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            NewGame();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Quit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure want to quit?", "Warring", MessageBoxButtons.OKCancel) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        void Quit()
        {
            Application.Exit();
        }
        void NewGame()
        {
            CountTime.Stop();
            TimeDown.Value = 0;
            ChessBoard.DrawChessBoard();
        }
    }
}
