using System;

namespace classesodev31
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.Kategori = "Ev Aletleri";

            Product product1 = new Product();
            product1.Ad = "Süpürge";
            product1.Fiyat = 1200;
            product1.Uretici = "Bosch";

            Product product2 = new Product();
            product2.Ad = "Çamaşır Makinesi";
            product2.Fiyat = 2000;
            product2.Uretici = "Arçelik";


            Product[] urunler = new Product[]
            {
                product1,product2
            };


            foreach (var urun in urunler)
            {
                Console.WriteLine(product.Kategori + " " + urun.Ad + " : " + urun.Fiyat + " : " + urun.Uretici);
            }

        }
    }

    class Product
    {
        public string Kategori { get; set; }

        public int Fiyat { get; set; }

        public string Ad { get; set; }

        public string Uretici { get; set; }











    }
    }



 




