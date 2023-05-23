using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework
{
    internal class RandomLuck
    {    
        public static bool IsLucky(int chance)
        {
            Random luck = new Random();
            return luck.Next(100) < chance;
        }
    }
}
