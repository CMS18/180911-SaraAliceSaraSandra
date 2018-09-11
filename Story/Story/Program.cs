using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Story
{
    class Program
    {
        static void Main(string[] args)
        {
            string ticketsEvent;
            string occasion;
            string belovedOne;
            string danger;
            
            Console.WriteLine("Hej! Skriv in din historia: ");
            Console.Write("Namn: ");
            string name = Console.ReadLine().ToLower();
            Console.Write("Type: ");
            string art = Console.ReadLine().ToLower();
            Console.Write("Mood: ");
            string mood = Console.ReadLine().ToLower();

            Console.WriteLine("Once upon a time...");
            Console.WriteLine("var det en " + mood + " " + art + " som hette " + name + ". ");

            Console.WriteLine(name + " was going to buy tickets to ");
            ticketsEvent = Console.ReadLine();
            Console.WriteLine(", as a present for their  ");
            occasion = Console.ReadLine();
            Console.WriteLine(" for the beloved ");
            belovedOne = Console.ReadLine();
            Console.WriteLine("Once they got to " + ticketsEvent + ", a huge ");
            danger = Console.ReadLine();
            Console.WriteLine(" fell on the poor " + name + ", while " + belovedOne + " was screaming!");
            Console.WriteLine("Talking about an unforgettable " + occasion + ", uh?");
            Console.WriteLine("THE END");

            

            

            Console.ReadLine();
        }
    }
}
