using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace homework
{
    public abstract class Person
    {
        private string name;
        private int age;
        public string Name
        {
            get { return name; }
            private set 
            {
                if (IsValidString(value) == true) { name = value; }
                else{ throw new ArgumentException("Name must contain only letters.");}                
            }
        }
        public int Age
        {
            get { return age; }
            private set
            {
                if(IsValidNumber(value) == true) { age = value; }
                else { throw new ArgumentException("Age must be positive number and contain oly digits."); }
            }
        }

        public Person(string name, int age)
        {
            Name = name;
            Age = age;
        }

        protected bool IsValidString(string str)
        {
            Regex regex = new Regex("^[A-Za-z]+$");
            if (regex.IsMatch(str)) { return true; }
            else { return false; }
        }
        protected bool IsValidNumber(int num)
        {
            Regex regex = new Regex("^[0-9]+$");
            if (regex.IsMatch(num.ToString()) && num > 0 && num < 100) { return true; }
            else { return false; }
        }

        
    }
}
