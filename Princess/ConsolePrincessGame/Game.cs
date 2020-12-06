using System;

namespace ConsolePrincessGame
{
    public class Game
    {
        public void GiveGame()
        {
           Console.Clear();

            do
            {
                Console.WriteLine("To start a new game, please press Enter key, and Backspace key to end the game ");

                switch (Console.ReadKey().Key)
                {
                    case ConsoleKey.Enter:
                        Setting.NewGame = false;
                        Setting.GameOver = true;
                        Setting.IncorrectKey = false;
                        break;

                    case ConsoleKey.Backspace:
                        Setting.NewGame = false;
                        Setting.GameOver = false;
                        Setting.IncorrectKey = false;
                        break;

                    default:
                        Setting.IncorrectKey = true;
                        Console.Clear();
                        break;
                }
            } while (Setting.IncorrectKey);
        }
        
        public void ResetGame()
        {
            Setting.Height = Setting.MinimumGameRows;
            Setting.Length = Setting.MinimumGamePillars;
            Setting.PlayerHealth = 10;
            Setting.NewGame = true;
            Setting.GameOver = false;
        }
    }
}















