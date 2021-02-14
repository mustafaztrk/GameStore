using GameStore.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstract
{
    public interface IProductService
    {
        void sell(Gamer gamer, Game game);
    }
}
