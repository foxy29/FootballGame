using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Goal
    {
        private int minute;
        private FootballPlayer player;

        public int Minute { get; set; }
        public FootballPlayer Player { get; set; }

        public Goal( int minute, FootballPlayer player)
        {
            Minute = minute;
            Player = player;
        }
    }
}
