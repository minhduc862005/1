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
