using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject
{
    //MicroService
    class GamerManager : IGamerService
    {
        public void Add(Gamer gamer)
        {

            Console.WriteLine("Kayıt oldu");
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine("Kayıt güncellendi");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine("Kayıt silindi");
        }
    }
}
