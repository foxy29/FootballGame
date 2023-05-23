using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Midfield : FootballPlayer
    {
        public Midfield(string name, int number, int age, double height)
            :base(name, number, age, height)
        {
            
        }
        public override int Defend()
        {
            int defendScore = 10;
            if (RandomLuck.IsLucky(60))
            {
                return defendScore++;
            }
            return defendScore;

        }
        public override int Attack()
        {
            int attackScore = 10;
            if (RandomLuck.IsLucky(60))
            {
                return attackScore++;
            }
            return attackScore;

        }
    }
}
