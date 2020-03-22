using System;
using System.Linq;

namespace LW2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Incorrect number of arguments!\nUsage remove_duplicates.exe <input string>");
            }
            else
            {
                Console.WriteLine(args[0].Distinct().ToArray());
            }

        }
    }
}
