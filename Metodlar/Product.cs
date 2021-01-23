using System;

using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "elma";
            urun1.Fiyatı = 15;
            urun1.Aciklama = "amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "karpuz";
            urun2.Fiyatı = 80;
            urun2.Aciklama = "diyarbakır karpuzu";

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //type safe--- tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyatı);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("---------------");

                SepetManager sepetManager1 = new SepetManager();

                //instance ornek
                //encapsulation


                SepetManager sepetManager = new SepetManager();
                sepetManager.Ekle(urun1);
                sepetManager.Ekle(urun2);

                sepetManager.Ekle2("armut", "yeşil armut", 12, 3);
                sepetManager.Ekle2("elma", "yeşil elma", 12, 5);
                sepetManager.Ekle2("kapurz", "diyarbakır karpuzu", 12, 7);

            }

        }
    }
}






// do not repeat yourself - DRY - CLEAN CODE - best practice