using System;

namespace ConsolePrincessGame
{
    public class Game
    {
        Player hero = new Player();

        public void GameLoss(ref int location, ref bool position, ref bool determination, ref int x, ref int y)
        {
            Console.Clear();

            Console.WriteLine("GAME OVER");
            Console.WriteLine("Do you want start new game?\n1)Yes\n2)No");

            while (!int.TryParse(Console.ReadLine(), out location))
            {
                Console.WriteLine("It isn't a number,write correctly");
            }

            if (location == 1)
            {
                position = false;
                determination = true;

            }

            else
            {
                position = false;
                determination = false;
            }
            x = 1;
            y = 1;
            hero.PlayerHealth = 10;
        }

        public void GameWin(ref int value, ref bool value2, ref bool value3, ref int x, ref int y)
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
            hero.PlayerHealth = 10;
        }




    }
}















