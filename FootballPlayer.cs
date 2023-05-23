using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace homework
{
    public abstract class FootballPlayer : Person
    {
        private int number;
        private double height;
        public int Number
        {
            get { return number; }
            private set 
            {
                if (IsValidNumber(value) == true) { number = value; }
                else { throw new ArgumentException("Number must be positive and between 1 and 100.");}
            }
        }
        public double Height
        {
            get { return height; }
            private set
            {
                if(IsValidDouble(value) == true) { height = value; }
                else { throw new ArgumentException("Height must be positive number and contain oly digits."); }
            }
        }
        public FootballPlayer(string name, int number, int age, double height ) 
            :base(name,age)
        {
            Number = number;
            Height = height;
        }
        public virtual int Attack()
        {
            int attackScore = 10;
            return attackScore;
        }

        public virtual int Defend()
        {
            int defendScore = 10;
            return defendScore;
        }

        protected bool IsValidDouble(double num)
        {
            if ( num > 0) { return true; }
            else { return false; }
        }

    }
}
