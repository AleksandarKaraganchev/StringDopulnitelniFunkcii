using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IzpratiMiImeil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Enter email: ");
            string email = Console.ReadLine();
            string[] word = email.Split('@');
            if (SumOfLetters(word[0]) >= SumOfLetters(word[1]))
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one!");
            }
        }
        private static int SumOfLetters(string word)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                count = count + word[i];
            }
            return count;
        }
    }
}

