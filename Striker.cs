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
        private void Strike()
        {

        }

        public override void Play()
        {
            Strike();
        }
    }
}
