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
