﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SnakeAndLadderProgram
{
    public class SnakeAndLadder
    {
        public const int No_Play = 0;
        public const int Ladder = 1;
        public const int snake = 2;
        private int PlayerPosition;
        public const int Winning = 100;
        int StartPoint = 0;
        public void StartGame()
        {
            Console.WriteLine("Game Started");
            Console.WriteLine("Player Position:", PlayerPosition);
            Random random = new Random();
            //int DiceRolled = random.Next(1, 7);
            //Console.WriteLine("Dice Rolled : {0} ", DiceRolled);
            //PlayerPosition = PlayerPosition + DiceRolled;
            //Console.WriteLine("Player Position: {0}", PlayerPosition);
            //int Option = random.Next(0, 3);
            //Console.WriteLine("Dice Value :" + Option);
            //switch (Option)
            //{
            //    case No_Play:
            //        Console.WriteLine("No Play");
            //        break;
            //        case Ladder:
            //        PlayerPosition += DiceRolled;
            //        Console.WriteLine("Got Ladder : " + PlayerPosition);
            //        break;
            //    case snake:
            //        PlayerPosition -= DiceRolled;
            //        Console.WriteLine("Snke Atteack : " + PlayerPosition);
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Option");
            //        break;
            while (StartPoint < Winning)
            {
                int DiceRolled = random.Next(1, 7);
                int Option = random.Next(0, 3);
                switch (Option)
                {
                    case No_Play:
                        Console.WriteLine("No Play");
                        break;
                        case Ladder:
                        StartPoint += DiceRolled;
                        Console.WriteLine("Dice Rolls Value : +{0} ", DiceRolled);
                        Console.WriteLine("Got Ladder : " + StartPoint);
                        if (StartPoint > Winning)
                        {
                            StartPoint -= DiceRolled;
                        }
                        Console.WriteLine("Player Position : " + StartPoint);
                        break;
                        case snake:
                        StartPoint -= DiceRolled;
                        Console.WriteLine("Dice Rolls Value : -{0}", DiceRolled);
                        Console.WriteLine("Snake Attack : " + StartPoint);

                        if (StartPoint < 0)
                        {
                            StartPoint = 0;
                        }
                        Console.WriteLine("Player Position : " + StartPoint);
                        break;
                }
                if(StartPoint == Winning)
                {
                    Console.WriteLine("Won");

                }
            
            }
            
        }
        
    }
    
}
