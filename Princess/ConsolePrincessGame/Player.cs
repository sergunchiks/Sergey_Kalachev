using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrincessGame 
{
   public class Player
    {
        private int playerhealth;
        private string playeravatar;
        public int PlayerHealth { get; set; } = 10;
        public string PlayerAvatar { get; set; } = "|P|";
       
        public void PlayerMovement(ref int x, ref int y)
        {
            
            ConsoleKey consolekey = Console.ReadKey().Key;
            switch (consolekey)
            {
               
                case ConsoleKey.DownArrow:
                    if (y == 11)
                    {
                        break;
                    }
                    else
                    {
                        y += 1;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (x == 11)
                    {
                        break;
                    }
                    else
                    {
                        x += 1;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (y == 1)
                    {
                        break;
                    }
                    else
                    {
                        y -= 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
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
