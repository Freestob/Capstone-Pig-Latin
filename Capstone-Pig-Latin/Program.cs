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
            //string front = "", back = "";
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
                userWord = userWord.Insert(index, " ");
                string[] temp = userWord.Split(' ');
                string back = temp[0];
                string front = temp[1];
                
                Console.WriteLine(front + back + "ay");
                Console.ReadLine();
            }
        }
    }
}
