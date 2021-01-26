using System;
using System.Collections.Generic;

namespace Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Campaigns camaigns = new Campaigns() { };
            Campaigns campaigns = new Campaigns() { };
            Players player = new Players() { };
            PlayersManager playersManager = new PlayersManager() { };
            Games game = new Games() { };
            player.PlayersId = 1;
            player.PlayersName = "Name";
            player.PlayersEmail = "player@hotmail.com";
            game.GamesName = "Call of duty";
            game.GamesPrice = 50;
            camaigns.CampaignsName = "Campaigns Name";
            campaigns.Price = 15;

            
            playersManager.TcKontrol(player);
            List<Games> games = new List<Games>() { game };
            List<Players> players = new List<Players>() { player };
            List<Campaigns> campaings  = new List<Campaigns>() { PriceCampaigns };

            
        }
    }
}
