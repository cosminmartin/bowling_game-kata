using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bowling_Game;

namespace Utilities
{
    public static class Utl
    {      
        public static int KnockedPins()
        {
            int pins;

            Random random = new Random();

            pins = random.Next(0, 11);
         
            return pins;
        }

        public static int StrikeOrSpare(int pins)
        {
          
            return 0;
        }
    }

}
