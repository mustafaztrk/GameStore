using GameStore.Abstract;
using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Concrete
{
    class ProductManeger : IProductService
    {
        private IEntity _gamer, _game;
        public ProductManeger(IEntity gamer, IEntity game)
        {
            _gamer = gamer;
            _game = game;
        }

        public void sell(Gamer _gamer, Game _game)
        {
            if (_gamer.Balance>=_game.UnitPrice)
            {
                Console.WriteLine(_game.GameName + " Alındı " + _gamer.Nick + " -" + _game.UnitPrice);
                _gamer.Games.Add(_game);
                _gamer.Balance -= _game.UnitPrice;
            }
            else
            {
                Console.WriteLine(_game.GameName + " Alınamadı " + _gamer.Nick);

            }
        }

        public void sell(Gamer _gamer, Game _game,List<Campaign> campaigns)
        {
            foreach (var campaign in campaigns)
            {
                _game.UnitPrice = _game.UnitPrice - _game.UnitPrice * campaign.DiscountRate / 100;
            }
            if (_gamer.Balance >= _game.UnitPrice)
            {
                Console.WriteLine(_game.GameName + " Alındı " + _gamer.Nick+" -"+_game.UnitPrice);
                _gamer.Games.Add(_game);
                _gamer.Balance -= _game.UnitPrice;
            }
            else
            {
                Console.WriteLine(_game.GameName + " Alınamadı " + _gamer.Nick);

            }
        }
    }
}
