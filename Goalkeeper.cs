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
        
        private void GoalKeep()
        {
            /*
            bool isThereGoal = false;
            if (!RandomLuckcs.IsLucky(50))
            {
                return isThereGoal = true;
            }
            //return is;*/
        }

        public override bool Play()
        {
            GoalKeep();
        }
    }
}
