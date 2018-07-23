using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone_Pig_Latin
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                char[] vowelList = new char[] { 'a', 'e', 'i', 'o', 'u' };
                Console.WriteLine("This will translate what you type into Pig Latin!");
                string userWord = Console.ReadLine().ToLower();

                if (userWord.StartsWith("a") || userWord.StartsWith("e") || userWord.StartsWith("i") || userWord.StartsWith("o") || userWord.StartsWith("u"))
                {
                    Console.WriteLine(userWord + "way");
                    Console.ReadKey();
                }
                else
                {
                    int index = userWord.IndexOfAny(vowelList);
                    userWord = userWord.Insert(index, " ");
                    string[] temp = userWord.Split(' ');
                    string back = temp[0];
                    string front = temp[1];

                    Console.WriteLine(front + back + "ay");
                    Console.ReadLine();

                }
                Console.WriteLine("Would you like to translate another word?");

                if (Console.ReadLine().ToLower() != "y")
                {
                    Console.WriteLine("Ankthay youway!");
                    Console.ReadKey();
                    break;
                }
            }

        }
    }
}
