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
            else 
            {
                int index = userWord.IndexOf("a");
                userWord = userWord.Remove(index, 1).Insert(index, ",");
                /* for (int i = 1; i <= userWord.Length; i++) //if userWord[i] == vowelList
                 {
                     if (userWord[i] == 'a' || userWord[i] == 'e' || userWord[i] == 'i' || userWord[i] == 'o' || userWord[i] == 'u')
                     {
                         Console.WriteLine("Hey");
                         Console.Read();
                         break;
                     }
                 }*/
                Console.WriteLine(userWord);
                Console.ReadLine();
            }

            Console.WriteLine(back + front + "ay");
            Console.ReadKey();
            //  Console.WriteLine(output);
            Console.ReadKey();
        }
    }
}
