using System;
using CDA2005_VS_Intro.Models;

namespace CDA2005_VS_Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.DarkBlue;

            Console.WriteLine("Hello World!");
            
            Point tata = new Point();

            tata = null;

            Point toto = new Point(1, 2);

            Point titi = new Point(1, "");

            Point tutu = new Point("", 1);

            Point tyty = new Point(a: 1, b: "");


            Console.Read();
        }
    }
}
