using System;

namespace BankaMusteriTakip
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();


            musteri.Ad = "Engin";
            musteri.Soyad = "DEMİROĞ";
            musteri.Id = "151239847";
            musteri.TelNo = "0505 024 31 31";
            musteri.DateTime = "1 Ocak 1982";
            musteri.Ikamet = "Ankara";
            musteri.Cuzdan = 30.000;





            Musteri musteri1 = new Musteri();


            musteri1.Ad = "Burak";
            musteri1.Soyad = "ADIYAMAN";
            musteri1.Id = "135124975";
            musteri1.TelNo = "0506 012 31 44";
            musteri1.DateTime = "1 Aralık 2004";
            musteri1.Ikamet = "İstanbul";
            musteri1.Cuzdan = 10.000;

            Musteri[] musteriler = new Musteri[]
            {

                musteri, musteri1


            };

            foreach (var bankaMusteri in musteriler)

            {

                Console.WriteLine("Id: " + bankaMusteri.Id);
                Console.WriteLine("İsim: " + bankaMusteri.Ad);
                Console.WriteLine("Soyisim: " + bankaMusteri.Soyad);
                Console.WriteLine("Telefon Numarası: " + bankaMusteri.TelNo);
                Console.WriteLine("Ikamet Ettiği Yer: " + bankaMusteri.Ikamet);
                Console.WriteLine("Doğum Tarihi: " + bankaMusteri.DateTime);
                Console.WriteLine("Bakiye: " + bankaMusteri.Cuzdan);

                Console.WriteLine("---------------------------------");


            }

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Add(musteri1);
            musteriManager.Add(musteri);

            musteriManager.Delete(musteri1);
            musteriManager.Delete(musteri);



           




        }

    }
}
