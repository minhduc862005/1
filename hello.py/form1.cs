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
 // di chuyển bóng
 ball.Left += ballXSpeed;
 ball.Top += ballYSpeed;
 // bóng chạm trần hoặc sàn
 if (ball.Top < 0 || ball.Top + ball.Height > this.ClientSize.Height)
 {
     ballYSpeed = -ballYSpeed;
 }
 // bóng chạm trần hoặc sàn
 if (ball.Top < 0 || ball.Top + ball.Height > this.ClientSize.Height)
 {
     ballYSpeed = -ballYSpeed;
 }
// bóng chạm thanh player2
if (ball.Bounds.IntersectsWith(player2.Bounds))
{
    ballXSpeed = -Math.Abs(ballXSpeed); // luôn đi sang trái
}
// bóng ra ngoài bên trái → Player2 ghi điểm
if (ball.Left < 0)
{
    player2Score++;
    ResetBall();
}
// bóng ra ngoài bên phải → Player1 ghi điểm
if (ball.Left + ball.Width > this.ClientSize.Width)
{
    player1Score++;
    ResetBall();
}
    // cập nhật tiêu đề form
    this.Text = "Player1: " + player1Score + " -- Player2: " + player2Score;
    if (player1Score >= 5)
    {
        GameOver("🎉 Player 1 thắng!");
    }
    else if (player2Score >= 5)
    {
        GameOver("🎉 Player 2 thắng!");
    }
}
 private void KeyIsDown(object sender, KeyEventArgs e)
 {
     if (e.KeyCode == Keys.W)
     {
         wDown = true;
     }
     if (e.KeyCode == Keys.S)
     {
         sDown = true;
     }
     if (e.KeyCode == Keys.Up)
     {
         upDown = true;
     }
     if (e.KeyCode == Keys.Down)
     {
         downDown = true;
     }
 }
