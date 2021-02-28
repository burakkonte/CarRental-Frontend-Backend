using System;

namespace switchodevornek2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 125;

            switch (x % 2)
            {
                case 0:
                    Console.WriteLine($"{x} is even value");
                    break;
                case 1:
                    Console.WriteLine($"{x} is odd Value");
                    break;
            }
        }
    }
}
