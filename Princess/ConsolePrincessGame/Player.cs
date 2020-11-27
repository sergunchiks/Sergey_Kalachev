using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrincessGame 
{
    class Player
    {
        private int playerhealth;
        private string playeravatar;
        public int PlayerHealth { get; set; } = 10;
        public string PlayerAvatar { get; set; } = "|P|";
        private int dir;
        public void PlayerMovement(ref int x, ref int y)
        {
            while (!int.TryParse(Console.ReadLine(), out dir))
            {
            }
            switch (dir)
            {
                case 5:
                    break;
                case 2:
                    if (y == 11)
                    {
                        break;
                    }
                    else
                    {
                        y += 1;
                    }
                    break;
                case 6:
                    if (x == 11)
                    {
                        break;
                    }
                    else
                    {
                        x += 1;
                    }
                    break;
                case 8:
                    if (y == 1)
                    {
                        break;
                    }
                    else
                    {
                        y -= 1;
                    }
                    break;
                case 4:
                    if (x == 1)
                    {
                        break;
                    }
                    else
                    {
                        x -= 1;
                    }
                    break;
            }
        }

        
        

    }
}
