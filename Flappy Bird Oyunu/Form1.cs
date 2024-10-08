using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Oyunu
{
    public partial class Form1 : Form
    {
        int BoruHızı = 8;
        int gravity = 10;
        int score = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void GameTimerEvent(object sender, EventArgs e)
        {
            FlappyBird.Top += gravity;
            BoruAlt.Left -= BoruHızı;
            BoruUst.Left -= BoruHızı;
            ScoreText.Text = "Score: " + score;
            if (BoruAlt.Left <-150)
            {
                BoruAlt.Left = 800;
                score++;
            }
            if (BoruUst.Left <- 180)
            {
                BoruUst.Left = 950;
                score++;
            }
            if(FlappyBird.Bounds.IntersectsWith(BoruAlt.Bounds)|| FlappyBird.Bounds.IntersectsWith(BoruUst.Bounds)||FlappyBird.Bounds.IntersectsWith(Zemin.Bounds))
            {
                endGame();
            }

            if (score>5)
            {
                BoruHızı = 15;
            }

            if (FlappyBird.Top<-25)
            {
                endGame();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = -10;
            }
        }

        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {
                gravity = 10;
            }
        }
        private void endGame()
        {
            GameTimer.Stop();
            ScoreText.Text = "Game Over!!!";
        }
    }
}
