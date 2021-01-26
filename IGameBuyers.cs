using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    interface IGameBuyers
    {
        void AddGame(Games game);
        void DeleteGame(Games game);
        void SellingGame(List<Games> games, List<Players> players, List<Campaigns> campaigns)
    }
}
