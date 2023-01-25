using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Utilities;
using Bowling_Game;

namespace Player
{
    public class Frame
    {
        public int[] NrOfPinsPerFrame(int pins)
        {
            int[] tries = new int[2]; // Each player is given two chances two knock down all the pins / per frame (round)


            if (pins == 10)
            {
                tries[0] = 10;
                tries[1] = 0;
            }
            else
            {
                tries[0] = pins; //I.ex.3    << II.ex: 5

                int remainingPins = 10 - tries[0]; //I.ex: 10-3=7              << II.ex: 10-5=5
                int secondTry = Utl.KnockedPins(); //I.ex.: 8                 << II.ex: 4

                if (secondTry >= remainingPins) //I.ex: 8 >= 7                  << II.ex: 4 >= 5  FALSE
                {
                    tries[1] = remainingPins; //I.ex: automat 7 (remaining pins are knocked - 7,8 or 9 numbers knocking the remaining 7)    << II.ex: ELSE
                }
                else
                {
                    tries[1] = secondTry; // I. ex:...                         << II.ex: secondTry = 4
                }

            }

            Console.WriteLine(tries[0].ToString());
            Console.WriteLine(tries[1].ToString());

            //int[] arrTry1 = { tries[0] };
            //Console.WriteLine("test arr " + arrTry1[0].ToString());

            if (tries[0] + tries[1] == 10)
            {
                Console.WriteLine("X Strike");
            }
            else
            {
                Console.WriteLine("Not strike");
            }

            //foreach (var item in tries)
            //{              
            //    Console.WriteLine("hello " + item);
            //}

            Console.WriteLine("\n");


            return tries;
        }
     
    }
}
