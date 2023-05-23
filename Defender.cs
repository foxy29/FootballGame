using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace homework
{
    public class Defender : FootballPlayer
    {
        public Defender(string name, int number, int age, double height)
            :base(name, number, age, height)
        {

        }

        public override int Defend()
        {
            int defendScore = 11;
            if (RandomLuck.IsLucky(50))
            {
                return defendScore++;
            }
            return defendScore;
            
        }

    }
}
