using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Skrivalishteto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            while (true)
            {
                string[] search = Console.ReadLine().Split();
                char searchedCharacter = char.Parse(search[0]);
                int minimumCount = int.Parse(search[1]);
                int indexOfTheFirstChar = 0;
                indexOfTheFirstChar = map.IndexOf(new string(searchedCharacter, minimumCount));
                if (indexOfTheFirstChar != -1)
                {
                    int endI = 0;
                    endI = indexOfTheFirstChar + minimumCount;
                    while (endI < map.Length && map[endI] == searchedCharacter)
                    {
                        endI++;
                    }
                    int lengthOfTheFoundString = 0;
                    lengthOfTheFoundString = endI - indexOfTheFirstChar;
                    Console.WriteLine($"Hideout found at index {indexOfTheFirstChar} and it is with size {lengthOfTheFoundString}!");
                    break;
                }
            }
        }
    }
}
