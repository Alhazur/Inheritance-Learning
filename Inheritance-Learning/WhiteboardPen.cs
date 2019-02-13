using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Learning
{
    class WhiteboardPen : Pen
    {
        readonly ConsoleColor boarColor;//beloe doska

        public WhiteboardPen(ConsoleColor color, string material, string name, double size) : base(color,material,name,size)//eto kostryktor iz osnovnogo  
        {
            boarColor = ConsoleColor.White;
        }
        public override void Write(string text)//doljen bit override chtoby abstract zarabotal
        {
            Console.BackgroundColor = boarColor;
            Console.ForegroundColor = Color;
            Console.WriteLine(text);
            Console.ResetColor();
            
        }
    }
}
