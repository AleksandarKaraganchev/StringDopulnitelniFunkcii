using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RazklashtaneNaMerlah
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            string input = Console.ReadLine();
            string template = Console.ReadLine();
            string output = input;
            int br = 0;
            while (output.Contains(template))
            {
                br++;
                int pos = output.IndexOf(template);
                int len = template.Length;
                output = output.Remove(pos, len);
            }
            if (br >= 2)
            {
                Console.WriteLine("Shaked it!");
            }
            Console.WriteLine("No shake!");
            Console.WriteLine($"output: {output}");
            //this task was done in class
        }
    }
}
