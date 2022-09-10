using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Jokkenpo
{
    public partial class Jokkepon : Form
    {
        public Jokkepon()
        {
            InitializeComponent();
        }

        private void btnStone_Click(object sender, EventArgs e)
        {
            StartGame(0);
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            StartGame(1);
        }

        private void btnScissors_Click(object sender, EventArgs e)
        {
            StartGame(2);
        }

        private void StartGame(int option)
        {
            lblResult.Visible = false;
            lblPC.Visible = false;
            lblPlayer.Visible = false;

            lblPlayer1.Visible = true;
            lblPC1.Visible = true;
            lblResult1.Visible = true;
            Game game = new Game();

            switch (game.Play(option))
            {
                case Game.Result.Win:
                    picResult.BackgroundImage = Image.FromFile("images/Ganhar.png");
                    goto default;

                case Game.Result.Lose:
                    picResult.BackgroundImage = Image.FromFile("images/Perder.png");
                    goto default;

                case Game.Result.Wow:
                    picResult.BackgroundImage = Image.FromFile("images/Empatar.png");
                    goto default;

                default:
                    picturePlayer1.Image = game.ImgPlayer;
                    picturePlayer2.Image = game.ImgPC;
                    break;
            }
        }

        private void picturePlayer1_Click(object sender, EventArgs e){}

        private void picturePlayer2_Click(object sender, EventArgs e){}
    }
}
