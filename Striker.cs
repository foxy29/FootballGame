using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    public class Striker : FootballPlayer
    {
        public Striker(string name, int number, int age, double height)
            :base(name, number, age, height)
        {
           
        }
        public override int Attack()
        {
            int defendScore = 12;
            if (RandomLuck.IsLucky(70))
            {
                return defendScore++;
            }
            return defendScore;

        }
    }
}
