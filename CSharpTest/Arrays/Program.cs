using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            numberContainer[0] = 1;

            numberContainer[1] = 20;

            numberContainer[2] = 3;



            var result = numberContainer[0] > numberContainer[1] && numberContainer[0] > numberContainer[2] ? "En büyük sayı 1.inci sayıdır" : numberContainer[1] > numberContainer[2] ? "En büyük sayı 2. inci sayıdır" : "En büyük sayı 3. sayıdır";

            Console.WriteLine(result);

        }
}
