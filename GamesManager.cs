using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class GamesManager
    {
        public void AddGame(Games games)
        {
            Console.WriteLine("Game Added");
        }

        public void DeleteGame(Games games)
        {
            Console.WriteLine("Game Deleted");
        }

        public void SellGame(List<Games> games, List<Players> players, List<Campaigns> campaigns)
        {
            foreach (var Players in players)
            {
                foreach (var Games in games)
                {
                    foreach (var Campaigns in campaigns)
                    {
                        Console.WriteLine(Players.PlayersId, Players.PlayersName, Players.PlayersEmail, Games.GamesName, Games.GamesPrice,
                        Campaigns.Price);
                    }
                }
            }
        }
    }
}
