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
            
            Console.WriteLine("Hej! Skriv in din historia: ");
            Console.Write("Namn: ");
            string name = Console.ReadLine().ToLower();
            Console.Write("Art: ");
            string art = Console.ReadLine().ToLower();
            Console.Write("Mood: ");
            string mood = Console.ReadLine().ToLower();
            

            Console.WriteLine("Once upon a time...");
            Console.WriteLine("var det en " + mood + " " + art + " som hette " + name + ". ");

            Console.WriteLine($"{name} var s� {mood} att {name} ville �ta n�got gott. " +
                $"Eftersom {name} �r en {art} s� �r det b�sta {name} vet pyttipanna.");
            Console.WriteLine($"Trots att {name} var s� {mood} s� satte {name} ig�ng med att laga " +
                $"pyttipannan. \nDet var supergott och {name} blev n�jd och glad!");     

            Console.ReadLine();
        }
    }
}
