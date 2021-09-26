using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatoriskOpgave4.Managers
{
    public class ManagePlayers : IManagePlayers
    {
        private static List<FootballPlayer> playerList = new List<FootballPlayer>() {
            new FootballPlayer(0, "Søren", 500, 67),
            new FootballPlayer(1, "Anders", 500, 50),
            new FootballPlayer(2, "Martin", 500, 34)
    };

        public IEnumerable<FootballPlayer> Get() {
            return new List<FootballPlayer>(playerList);
        }

        public FootballPlayer Get(int id) {
            return playerList.Find(i => i.ID == id);
        }

        public bool Create(FootballPlayer value) {
            playerList.Add(value);
            return true;
        }

        public bool Update(int id, FootballPlayer value) {
            FootballPlayer player = Get(id);
            if (player != null) {
                player.ID = value.ID;
                player.Name = value.Name;
                player.Price = value.Price;
                player.ShirtNumber = value.ShirtNumber;

                return true;
            }
            return false;
        }

        public FootballPlayer Delete(int id) {
            FootballPlayer player = Get(id);
            playerList.Remove(player);
            return player;
        }
    }
}
