using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Team
    {
        private Coach coach;
        private List<FootballPlayer> footballPlayers;
        private int averageAge;

        public Coach Coach { get; set; }
        public List<FootballPlayer> FootballPlayers
        {
            get { return footballPlayers; }
            set
            {
                if (value.Count >= 11 && value.Count <= 22){ footballPlayers = value;}
                else { throw new ArgumentOutOfRangeException("Footboll team must heave between 11 and 22 players.");}
            }
        }
        public int AverageAge 
        {
            get
            {
                foreach (var player in footballPlayers)
                {
                    averageAge = (footballPlayers.Sum(p => p.Age)) / 2;
                }
                return averageAge;
            }
        }

        public Team()
        {
            FootballPlayers = new List<FootballPlayer>();
        }

    }
}
