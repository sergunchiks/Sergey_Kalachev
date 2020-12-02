using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrincessGame 
{
   public class Player
    {
        
       
        public void PlayerMovement()
        {
            
            ConsoleKey pressedkey = Console.ReadKey().Key;
            switch (pressedkey)
            {

                case ConsoleKey.NumPad2:
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if (Setting.Height == Setting.MaximumGamePillars)
                    {
                        break;
                    }
                    else
                    {
                        Setting.Height += Setting.PlayerStep;
                    }
                    break;

                case ConsoleKey.NumPad6:
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    if (Setting.Length == Setting.MaximumGameRows)
                    {
                        break;
                    }
                    else
                    {
                        Setting.Length += Setting.PlayerStep;
                    }
                    break;

                case ConsoleKey.NumPad8:
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (Setting.Height == Setting.MinimumGamePillars)
                    {
                        break;
                    }
                    else
                    {
                        Setting.Height -= Setting.PlayerStep;
                    }
                    break;

                case ConsoleKey.NumPad4:
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    if (Setting.Length == Setting.MinimumGameRows)
                    {
                        break;
                    }
                    else
                    {
                        Setting.Length -= Setting.PlayerStep;
                    }
                    break;
            }
        }

        
        

    }
}
