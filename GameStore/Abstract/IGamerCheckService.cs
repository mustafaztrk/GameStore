using System;
using System.Collections.Generic;
using System.Text;

namespace GameStore.Abstract
{
    public interface IGamerCheckService
    {
        bool CheckIfRealGamer(Gamer gamer);
    }
}
