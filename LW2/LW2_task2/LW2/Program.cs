using System;

namespace LW2
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("No parameters were specified!");
            }
            else
            {
                Console.WriteLine($"Number of arguments: {args.Length}");
                Console.WriteLine($"Arguments: {string.Join(" ", args)}");
            }
            
        }
    }
}
