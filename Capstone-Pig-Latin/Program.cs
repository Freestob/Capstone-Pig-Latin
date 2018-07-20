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
            string front = "", back = "";
           char[] vowelList = new char[] { 'a', 'e', 'i', 'o', 'u' };
            Console.WriteLine("This will translate what you type into Pig Latin!");
           string userWord = Console.ReadLine();
            // string output = userWord.Substring((userWord.IndexOf('a')+1));
            if (userWord.StartsWith("a") || userWord.StartsWith("e") || userWord.StartsWith("i") || userWord.StartsWith("o") || userWord.StartsWith("u"))
            {
                Console.WriteLine(userWord + "way");
                Console.ReadKey();
            }
            else for (int i = 0; i <= userWord.Length; i++)
            {
                    string[] words = userWord.Split(vowelList, 2);
                    front = userWord.Substring(0,1);
                    back = userWord.Substring(1);
            }
            Console.WriteLine(back + front + "ay");
            Console.ReadKey();
            //  Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
