using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jokkenpo
{
    internal class Game
    {
        public enum Result
        {
            Win, Lose, Wow
        }

        public static Image[] images =
        {
            Image.FromFile("images/Pedra.png"),
            Image.FromFile("images/Papel.png"),
            Image.FromFile("images/Tesoura.png")
        };

        public Image ImgPC { get; private set; }
        public Image ImgPlayer { get; private set; }

        public Result Play(int player)
        {
            int pc = PlayPC();
            ImgPlayer = images[player];
            ImgPC = images[pc];

            if (player == pc)
            {
                return Result.Wow;
            } 
            else if((player == 0 && pc == 1) || (player == 1 && pc == 2) || (player == 2 && pc == 0))
            {
                return Result.Lose;
            } 
            else
            {
                return Result.Win;
            }
        }

        private int PlayPC()
        {
            int mil = DateTime.Now.Millisecond;

            if(mil < 333)
            {
                return 0;
            } else if (mil >= 333 && mil < 667)
            {
                return 1;
            } else
            {
                return 2;
            }
        }
    }
}
