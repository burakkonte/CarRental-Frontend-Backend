using System;

namespace CSharpTest
{
    class Program
    {
        static void Main(string[] args)
        {
            double piyasBugun = 20090.4;
            double piyasaDun = 500.3;

            bool sonuc = piyasaDun < piyasBugun;

            string mesajArtis = "Artış Oku";
            string mesajAzalis = "Düşüş Oku";

            if (sonuc == true)
            {
                Console.WriteLine(mesajArtis);
            }

            else 
            {
                Console.WriteLine(mesajAzalis);
            }

        }
    }
}
