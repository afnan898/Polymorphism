using System;
namespace Polymorphism_2673
{
    public class Epson : PrinterWindows
    {
        public override void Show()
        {
            Console.WriteLine("Epson display dimension: 10*11");
        }
        public override void Print()
        {
            Console.WriteLine("Epson printer printing...");
        }
    }
}