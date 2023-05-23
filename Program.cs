using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<FootballPlayer> players = new List<FootballPlayer>();

            players.Add(new Defender("Antonio", 2, 23, 2.40));
            players.Add(new Midfield("Antonio", 2, 25, 2.40));
            players.Add(new Striker("Antonio", 2, 26, 2.40));

            
        }
    }
}
