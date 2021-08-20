using System;
using System.Collections.Generic;
using System.Text;

namespace BankaMusteriTakip
{
    class MusteriManager

    {

        public void Add(Musteri musteriler)
        {
            Console.WriteLine("Müşteri başarıyla eklendi! " + musteriler.Ad + " " + musteriler.Soyad);



        }

        public void Delete(Musteri musteriler)
        {
            Console.WriteLine("Müşteri Sistemden Başarıyla Silndi " + musteriler.Ad + " " + musteriler.Soyad);

        }


        public void Update(Musteri musteriler)
        {

            Console.WriteLine("Müşteri Güncellendi! " + musteriler.Ad + " " + musteriler.Soyad);
        }

    }
















}
