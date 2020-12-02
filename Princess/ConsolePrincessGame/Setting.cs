using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrincessGame
{
    public class Setting
    {
        //Game
        public static int FirstCounter { get; set; }
        public static int SecondCounter { get; set; }
        public static bool IncorrectKey { get; set; }
        public static bool NewGame { get; set; }
        public static bool GameOver { get; set; }

        //Field
        public const int MaximumFieldPillars = 12;
        public const int MaximumFieldRows = 12;

        public const int MaximumGamePillars = 11;
        public const int MaximumGameRows = 11;

        public const int MinimumGamePillars = 1;
        public const int MinimumGameRows = 1;

        public const string HorizontalFieldBorder = "_";
        public const string VerticalFieldBorder = "|";
        public const string fieldCell = "?";

        //Player
        public static int PlayerHealth { get; set; } = 10;
        public const string PlayerIcon = "H";
        public const int PlayerStep = 1;
        public const int PlayerStartPositionOx = 1;
        public const int PlayerStartPositionOy = 1;
        public static int Length { get; set; } = PlayerStartPositionOx;
        public static int Height { get; set; } = PlayerStartPositionOy;

        //Bombs
        public const string BombIcon = "x";
        public static int NumberOfBombs { get; set; } = 10;
        public const int MaximumBombDamage = 10;
        public const int MinimumBombDamage = 1;

        //Prinsess
        public const string PrinsessIcon = "P";
        public const int PrincessLengthPosition = 10;
        public const int PrinsessHeightPosition = 10;
        

        

    }
        
}
