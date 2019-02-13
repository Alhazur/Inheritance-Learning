using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance_Learning
{
    abstract class Pen
    {
        protected ConsoleColor Color;//doljen bit dostup k dochernomy klassu protect daet
        protected string Material;
        protected string Name;
        protected double Size;

        public Pen(ConsoleColor color, string material, string name, double size)
        {
            Color = color;
            Material = material;
            Name = name;
            Size = size;
        }

        public abstract void  Write(string text);// nelzya vizvat abstract v main
        
    }
}
