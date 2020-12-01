using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolePrincessGame;

namespace ConsolePrincessGame
{

    class Program 
    {

        static void Main(string[] args)
        {
            int x = 1;
            int y = 1;
            string[,] field = new string[12, 12];
            string[,] mines = new string[12, 12];
            int location = 0;
            bool position; 
            bool determination;


            Game game = new Game();
            Player player = new Player();
            Random random = new Random();
            

            do
            {
                Console.Clear();

                for (int i = 1; i < 11; i++)
                {
                    mines[random.Next(1, 11), random.Next(1, 11)] = " P";
                }


                Console.WriteLine("Princess game");
                Console.WriteLine("Press any arrow keys to start");


                do
                {
                    position = true;
                    determination = true;

                    player.PlayerMovement(ref x, ref y);


                    Console.Clear();


                    int rows = field.GetUpperBound(0) + 1;
                    int pillars = field.Length / rows;


                    for (int i = 1; i < rows; i++)
                    {
                        for (int j = 1; j < pillars; j++)
                        {
                            field[i, j] = "| |";
                        }
                    }   


                        field[y, x] = player.PlayerAvatar;
                        field[11, 11] = " P";

                        Console.WriteLine($"Your HP {player.PlayerHealth}");

                        for (int f = 0; f < rows; f++)
                        {
                            for (int j = 0; j < pillars; j++)
                            {
                                Console.Write($"{field[f, j] }\t");
                            }

                            Console.WriteLine();
                            Console.WriteLine();
                        }

                        if (field[y, x] == field[11, 11])
                        {
                            game.GameWin(ref location, ref position, ref determination, ref x, ref y);
                        }

                        else if (field[y, x] == mines[x, y])
                        {
                            player.PlayerHealth -= random.Next(1, 10);

                            if (player.PlayerHealth <= 0)
                            {
                                game.GameLoss(ref location, ref position, ref determination, ref x, ref y);
                            }
                        }

                        field[y, x] = "";
                    
                } while (position);





            } while (determination);
        }
    }
}
