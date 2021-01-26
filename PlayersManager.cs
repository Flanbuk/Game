using System;
using System.Collections.Generic;
using System.Text;

namespace Game
{
    class PlayersManager
    {
        public void AddPlayers(Players player)
        {
            Console.WriteLine(player.PlayersName + "Player added" );
        }

        public void DeletePlayers(Players player)
        {
            Console.WriteLine(player.PlayersId,"+" player.PlayersName + "Player deleted");
        }

        public void TcKontrol(Players player)
        {
            Console.WriteLine("Tc control check");
        }
    }
}
