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
            



            string nameFriend;
            string artFriend;
            string moodFriend;

            Console.WriteLine("Once upon a time...");
            Console.WriteLine("var det en " + mood + " " + art + " som hette " + name + ". ");

            Console.WriteLine($"{name} var så {mood} att {name} ville äta något gott. " +
                $"Eftersom {name} är en {art} så är det bästa {name} vet pyttipanna.");
            Console.WriteLine($"Trots att {name} var så {mood} så satte {name} igång med att laga " +
                $"pyttipannan. \nDet var supergott och {name} blev nöjd och glad!");     

            Console.WriteLine("Den unika arten såg plötsligt en rosa ballong, ballongen presentera sig som:");
            string balloon = Console.ReadLine();
            Console.Write(", " + balloon + " blev förvånad över hur söt den " + art + " var.");
            Console.Write("Han var en VÄLDIGT " + mood + " " + art + " som levde djupt nere i havet tillsammans " +
                "med sin bästis ");
            nameFriend = Console.ReadLine().ToLower();
            Console.Write(" som var en ganska ");
            moodFriend = Console.ReadLine().ToLower();
            artFriend = Console.ReadLine().ToLower();
            Console.Write(". Tillsammans hade dom the time of their lifes!");

            

            Console.ReadLine();
        }
    }
}
