using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePrincessGame
{
    public class GameField
    {
        public string[,] Field { get; set; }

        public void RenderField()
        {
            Field = new string[Setting.MaximumFieldRows, Setting.MaximumFieldPillars];

            for (Setting.FirstCounter = 0; Setting.FirstCounter < Setting.MaximumFieldRows; Setting.FirstCounter++)
            {
                Field[0, Setting.FirstCounter] = Setting.HorizontalFieldBorder;
                Field[Setting.MaximumFieldRows-1 , Setting.FirstCounter] = Setting.HorizontalFieldBorder;
            }

            for (Setting.FirstCounter = 1; Setting.FirstCounter < Setting.MaximumFieldPillars - 1; Setting.FirstCounter++)
            {
                Field[Setting.FirstCounter, 0] = Setting.VerticalFieldBorder;
                Field[Setting.FirstCounter, Setting.MaximumFieldPillars - 1] = Setting.VerticalFieldBorder;
            }

            for (Setting.FirstCounter = 1; Setting.FirstCounter < Setting.MaximumFieldRows - 1; Setting.FirstCounter++)
            {

                for (Setting.SecondCounter = 1; Setting.SecondCounter < Setting.MaximumGamePillars - 1; Setting.SecondCounter++)
                {
                    Field[Setting.FirstCounter, Setting.SecondCounter] = Setting.fieldCell;
                }
            }
        }        
    }
}
