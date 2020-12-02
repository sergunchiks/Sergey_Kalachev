using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrincessGame
{
    public class BombLogic

    {
        public int BombDamage { get; set; }
        public string[,] Bombs { get; set; }

        public int BombPositionOx { get; set; }
        public int BombPositionOy { get; set; }

        Random random = new Random();

        
            
        public void BombsRendering()
        {
                BombDamage = random.Next(Setting.MinimumBombDamage, Setting.MaximumBombDamage);
                Bombs = new string[Setting.MaximumGameRows, Setting.MaximumGamePillars];
            
            {
                BombPositionOx = random.Next(Setting.MinimumGameRows, Setting.MaximumGameRows);

                BombPositionOy = random.Next(Setting.MinimumGamePillars, Setting.MaximumGamePillars);

                if (Bombs[BombPositionOx, BombPositionOy] == null)
                {
                    if (BombPositionOx != Setting.MinimumGameRows && BombPositionOy != Setting.MinimumGamePillars)
                    {
                        if (BombPositionOx != Setting.MaximumGameRows && BombPositionOy != Setting.MaximumGamePillars)
                        {
                            Bombs[BombPositionOx, BombPositionOy] = Setting.PlayerIcon;
                        }
                    }
                }
                else
                {
                    Setting.NumberOfBombs++;
                }
            }
        }
    }
}

