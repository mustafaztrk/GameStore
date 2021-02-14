using GameStore.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Entity
{
    public class Game:IEntity
    {
        public string GameName { get; set; }
        public decimal UnitPrice { get; set; }
        public int GameSize { get; set; }

    }
}
