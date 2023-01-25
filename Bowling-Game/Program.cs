//Bowling Game Kata
//============
//Source: [https://github.com/ardalis/kata-catalog](https://github.com/ardalis/kata-catalog)

//# Background #

//A completed game of bowling consists of 10 frames. In each frame, the player has two opportunities to knock down 10 pins. The score for the frame is the total number of pins knocked down, plus bonuses for strikes and spares.

//A *spare* occurs when the player knocks down all 10 pins in two tries. The bonus for that frame is the number of pins knocked down by the next roll. For example, if you get a spare in the 3rd frame, and in the fourth frame your first roll knocks down 5 pins, your score in the 3rd frame would be 15 (10 + bonus of 5).

//A *strike* occurs when the player knocks down all 10 pins on the first try. The bonus for that frame is the value of the next two balls rolled.

//In the tenth frame, a player who rolls a spare or strike is allowed to roll the extra balls to complete the frame. However, no more than three balls can be rolled in the tenth frame.

//# Instructions #
//- Write a class 'Game' with two methods
//- void Roll(int pins) is called each time the player rolls a ball. The argument is the number of pins knocked down.
//- int Score() is called only at the very end of the game. It returns the total score for that game. 

//# Resources #
//- [Walkthrough by Uncle Bob Martin](http://butunclebob.com/ArticleS.UncleBob.TheBowlingGameKata)




// See https://aka.ms/new-console-template for more information

using System;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using Bowling_Game;
using Utilities;
using Player;
using System.Collections;

namespace Program
{
    internal class Program
    {      
        static void Main(string[] args)
        {

            //public static void Fill<T>(T[] array, T value, int startIndex, int count);

            Game game = new Game();

            Frame frame = new Frame();

            //int knockedPins = Utl.KnockedPins();
            //int [] triesArr = frame.NrOfPinsPerFrame(knockedPins);

            //int[] tryArr1 = triesArr[0];
            //int[] tryArr2 = triesArr[1];


            //game.Roll(arr[0]);

            int frames = 0;

            //ArrayList allFramesArr = new ArrayList();

            //int[,] allFramesArr;
            //allFramesArr = new int[frameArr[0], frameArr[1]];

           
            while (frames <= 9)
            {
                
                int knockedPins = Utl.KnockedPins();
                frame.NrOfPinsPerFrame(knockedPins);

                //int[] arrFrame = frame.NrOfPinsPerFrame(knockedPins);

                //int[,] allFramesArr = { { arrFrame[0], arrFrame[1] }};

                //Console.WriteLine(allFramesArr[0, 0].ToString());

                frames++;
            }

            
           



            //Console.WriteLine(allFramesArr[0][0].ToString());


            //for (int x = 0; x < 10; x++)
            //{
            //    for (int y = 0; y < 10; y++)
            //    {
            //        Console.WriteLine(allFramesArr[x] + allFramesArr[y]);                  
            //    }
            //}




            //if(frames == 10) { Score() }


        }
    }
}
