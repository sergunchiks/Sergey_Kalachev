using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsolePrincessGame;

namespace ConsolePrincessGame
{

    public class Program 
    {

        static void Main(string[] args)
        {
            GameField gamefield = new GameField();
            Game game = new Game();
            Player player = new Player();
            Bomb bomb = new Bomb();

            do
            {
                Console.Clear();
                game.ResetGame();
                gamefield.RenderField();
                bomb.RederBomb();

                Console.WriteLine("Press keyboard to start(W,A,S,D, Left Arrow, Right Arrow, Up Arrow, Down Arrow, Num8, Num4, Num6, Num2)");

                do
                {
                    player.LetsMove();

                    Console.Clear();

                    gamefield.Field[Setting.Height, Setting.Length] = Setting.PlayerIcon;

                    if (Setting.PlayerIcon == bomb.Bombs[Setting.Height, Setting.Length])
                    {
                        gamefield.Field[Setting.Height, Setting.Length] = Setting.BombIcon;
                    }

                    gamefield.Field[Setting.PrincessLengthPosition, Setting.PrinsessHeightPosition] = Setting.PrinsessIcon;

                    Console.WriteLine("Console Princess game");
                    Console.WriteLine($"Your Health {Setting.PlayerHealth}");

                    for (Setting.FirstCounter = 0; Setting.FirstCounter < Setting.MaximumFieldRows; Setting.FirstCounter++)
                    {
                        for (Setting.SecondCounter = 0; Setting.SecondCounter < Setting.MaximumFieldPillars; Setting.SecondCounter++)
                        {
                            Console.Write($"{  gamefield.Field[Setting.FirstCounter, Setting.SecondCounter] }\t");
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                    }
                    
                    if (gamefield.Field[Setting.Height, Setting.Length] == gamefield.Field[Setting.PrincessLengthPosition, Setting.PrinsessHeightPosition])
                    {
                        Console.WriteLine("Congratulations!!! You saved the Princess!!! ");

                        game.LetsPlay();
                    }
                    else if (Setting.PlayerIcon == bomb.Bombs[Setting.Height, Setting.Length])
                    {
                        bomb.Bombs[Setting.Height, Setting.Length] = Setting.BombIcon;
                        Setting.PlayerHealth -= bomb.BombDamage;

                        if (Setting.PlayerHealth <= 0)
                        {
                            Console.WriteLine("GAME OVER");

                            game.LetsPlay();
                        }
                    }
                    if (gamefield.Field[Setting.Height, Setting.Length] != Setting.BombIcon)
                    {
                        gamefield.Field[Setting.Height, Setting.Length] = Setting.fieldCell;
                    }
                } while (Setting.NewGame);

            } while (Setting.GameOver);
        }
    }
}
