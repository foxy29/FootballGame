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

        private void RunBallToStriker()
        {

        }

        public override void Play()
        {
            RunBallToStriker();
        }
    }
}
