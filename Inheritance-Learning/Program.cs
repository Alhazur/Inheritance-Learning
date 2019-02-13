using System;
using System.Collections.Generic;

namespace Inheritance_Learning
{
    class Program
    {
        static void Main(string[] args)
        {
            Pen pen = new WhiteboardPen(ConsoleColor.Blue, "Plast", "ArtLine517", 1.2);
            pen.Write("Test our pen");

            IncPen incPen = new IncPen(ConsoleColor.DarkGreen, "Plast and rubber", "Lexicon pen", 1.0);

            incPen.ToggleTipOnPen();

            bool tryPen = true;
            while (tryPen)
            {
                try
                {
                    incPen.Write("Test 2 with Incpen");
                    tryPen = false;//ostanovit 
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    incPen.ToggleTipOnPen();
                }

            }
            Console.WriteLine("-----------------------");

            Money swe100kr = new SwedBill() { Name = "Kr", Worth = 100 };
            Money swe5kr = new SwedCoin() { Name = "Kr", Worth = 5 };

            List<Money> money = new List<Money>
            {
                swe5kr,
                swe100kr
            };
            foreach (var item in money)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey(true);
        }
    }
}
