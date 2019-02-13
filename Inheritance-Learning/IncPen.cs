using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Learning
{
    class IncPen : Pen
    {
        bool isOut;//rabotaet ili net! ruchka 
        //esli net get i set to eto pole

        public IncPen(ConsoleColor color, string material, string name, double size) : base(color, material, name, size)
        {
            isOut = false;
        }
        public override void Write(string text)//eto znachit chto tolko text budet okrashen
        {
            
            if (isOut)
            {
                Console.ForegroundColor = Color;
                Console.WriteLine(text);
                Console.ResetColor();
            }
            else
            {
                throw new Exception("Tip of pen is not out.");
            }

        }
        public bool ToggleTipOnPen()
        {
            if (isOut)//isOut==True ne nujno
            {
                isOut = false;
            }
            else
            {
                isOut = true;
            }
            return isOut;
        }
    }
}
