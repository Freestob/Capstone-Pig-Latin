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
            Console.WriteLine("This will translate what you type into Pig Latin!");
           string userWord = Console.ReadLine();
            string output = userWord.Substring((userWord.IndexOf('a')+1));
            if (userWord.StartsWith("a") || userWord.StartsWith("e") || userWord.StartsWith("i") || userWord.StartsWith("o") || userWord.StartsWith("u"))
            {
                Console.WriteLine(userWord + "way");
                Console.ReadKey();
            }
            Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
