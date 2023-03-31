using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cenzura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.Write("Enter word: ");
            string[] word = Console.ReadLine().Split().ToArray();
            Console.Write("Enter sentence: ");
            string sentence = Console.ReadLine();

            foreach (var n in word)
            {
                if (sentence.Contains(n))
                {
                    sentence = sentence.Replace(n, new string('*', n.Length));
                }
            }
            Console.WriteLine("------------------------------------------------------");
            Console.WriteLine(sentence);
            Console.WriteLine("------------------------------------------------------");
        }
    }
}
