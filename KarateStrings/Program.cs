using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarateStrings
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string string1 = Console.ReadLine();
            int strength = 0;
            for (int i = 0; i < string1.Length; i++)
            {
                if (string1[i] == '>')
                {
                    strength = strength + int.Parse(string1[i + 1].ToString());
                }
                else if (strength > 0)
                {
                    string1 = string1.Remove(i, 1);
                    i--;
                    strength--;
                }
            }
            Console.WriteLine(string1);
        }
    }
}
