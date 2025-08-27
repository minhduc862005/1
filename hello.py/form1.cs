using System;
using System.Drawing;
using System.Windows.Forms;

namespace gameponggk
{
    public partial class Form1 : Form
    {
        // tốc độ di chuyển
        int playerSpeed = 8;

        // tốc độ bóng
        int ballXSpeed = 5;
        int ballYSpeed = 5;

        // điểm số
        int player1Score = 0;
        int player2Score = 0;

        // trạng thái phím
        bool wDown, sDown, upDown, downDown;

        public Form1()
        {
            InitializeComponent();
            ResetBall();
        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            // di chuyển Player1
            if (wDown && player1.Top > 0)
            {
                player1.Top -= playerSpeed;
            }
            if (sDown && player1.Top + player1.Height < this.ClientSize.Height)
            {
                player1.Top += playerSpeed;
            }

            // di chuyển Player2
            if (upDown && player2.Top > 0)
            {
                player2.Top -= playerSpeed;
            }
            if (downDown && player2.Top + player2.Height < this.ClientSize.Height)
            {
                player2.Top += playerSpeed;
            }
