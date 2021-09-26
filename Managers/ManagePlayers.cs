using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ObligatoriskOpgave4.Managers
{
    public class ManagePlayers : IManagePlayers
    {
        private static int nextID = 0;

        private static List<FootballPlayer> playerList = new List<FootballPlayer>() {
            new FootballPlayer(nextID++, "Søren", 500, 67),
            new FootballPlayer(nextID++, "Anders", 500, 50),
            new FootballPlayer(nextID++, "Martin", 500, 34)
    };

        public IEnumerable<FootballPlayer> Get() {
            return playerList;
        }

        public FootballPlayer Get(int id) {
            return playerList.Find(i => i.ID == id);
        }

        public bool Create(FootballPlayer value) {
            value.ID = nextID++;
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
