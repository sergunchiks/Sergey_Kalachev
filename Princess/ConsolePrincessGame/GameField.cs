using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrincessGame
{
    class Game : Player
    {
        public void LoseGame(ref int value, ref bool value2, ref bool value3, ref int x, ref int y)
        {
            Console.Clear();
            Console.WriteLine("GAME OVER");
            Console.WriteLine("Do you want start new game?\n1)Yes\n2)No");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("It isn't a number,write correctly");
            }
            if (value == 1)
            {
                value2 = false;
                value3 = true;

            }
            else
            {
                value2 = false;
                value3 = false;
            }
            x = 1;
            y = 1;
            PlayerHealth = 10;
        }

        public void WinGame(ref int value, ref bool value2, ref bool value3, ref int x, ref int y)
        {
            Console.Clear();
            Console.WriteLine(" Consgratulations!!! Princess is safe!!! ");
            Console.WriteLine("Do you want start new game?\n1)Yes\n2)No");
            while (!int.TryParse(Console.ReadLine(), out value))
            {
                Console.WriteLine("It isn't a number,write correctly");
            }
            if (value == 1)
            {
                value2 = false;
                value3 = true;
            }
            else
            {
                value2 = false;
                value3 = false;
            }
            x = 1;
            y = 1;
            PlayerHealth = 10;
        }


        

    }
}




          
       
    
       
        
    

    

    

