using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Goalkeeper : FootballPlayer
    {
        public Goalkeeper(string name, int number, int age, double height)
            :base(name, number, age, height)
        {
            
        }
        public override int Defend()
        {
            int defendScore = 12;
            if (RandomLuck.IsLucky(80))
            {
                return defendScore++;
            }
            return defendScore;

        }
        public override int Attack()
        {
            int attackScore = 0;
            return attackScore;

        }
    }
}
