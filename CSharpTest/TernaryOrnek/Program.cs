using System;

namespace TernaryOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            string kullaniciAdi = "", sifre = "";

            Console.WriteLine("Kullanici Adini Girin: ");

            kullaniciAdi = Console.ReadLine();

            Console.WriteLine("Sifreyi Girin");

            sifre = Console.ReadLine();

            string durum = (kullaniciAdi == "admin" && sifre == "12345") ? "Giris Basarili" : "Kullanici adi ve ya sifre hatali";

            Console.WriteLine(durum);


        }
    }
}
    
