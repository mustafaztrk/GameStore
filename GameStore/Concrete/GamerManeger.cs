using GameStore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    public class GamerManeger : IGamerService
    {
        private IGamerCheckService _gamerCheckService;
         
        public GamerManeger(IGamerCheckService gamerCheckService)
        {
            _gamerCheckService = gamerCheckService;
        }
        public void Add(Gamer gamer)
        {
            if (_gamerCheckService.CheckIfRealGamer(gamer))
            {
                Console.WriteLine(gamer.FirstName+" isimli oyuncu kaydedildi!");
            }
            else
            {
                Console.WriteLine("Kayıt Başarısız");
            }
        }

        public void Delete(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName+" isimli oyuncu silindi!");
        }

        public void Update(Gamer gamer)
        {
            Console.WriteLine(gamer.FirstName + " isimli oyuncu bilgileri güncellendi!");
        }
    }
}
