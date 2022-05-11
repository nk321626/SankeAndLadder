using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace SnakeAndLadderProgram
{
    public class SnakeAndLadder
    {
        //public const int No_Play = 0;
        //public const int Ladder = 1;
        //public const int snake = 2;
        //private int PlayerPosition;
        //public const int Winning = 100;
        //int StartPoint = 0;
        //int Count = 0;
        //constant
        public const int POSITION = 0;
        public const int WINNING_POSITION = 100;
        //Variable
        int diceCountForPlayer1 = 0;
        int diceCountForPlayer2 = 0;
        int positionForPlayer1 = 0;
        int positionForPlayer2 = 0;
        int position = 0;
        public void StartGame()
        {
            //Console.WriteLine("Game Started");
            //Console.WriteLine("Player Position:", PlayerPosition);
            Random random = new Random();
            int player = random.Next(1, 7);
            //Console.WriteLine("Dice Rolled : {0} ", DiceRolled);
            //PlayerPosition = PlayerPosition + DiceRolled;
            //Console.WriteLine("Player Position: {0}", PlayerPosition);
            Random random1 = new Random();
            int Option = random1.Next(0, 3);
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
            Console.WriteLine("Snake And Ladder Game");
            while (diceCountForPlayer1 != WINNING_POSITION && diceCountForPlayer2 != WINNING_POSITION)
            {
                //Count++;
                //int DiceRolled = random.Next(1, 7);
                //int Option = random.Next(0, 3);
                diceCountForPlayer1++;
                switch (Option)
                {
                    //case No_Play:
                    //    Console.WriteLine("No Play");
                    case 0:
                        case 1:
                        Console.WriteLine("Player stay at the same position");
                        break;

                        case 2:
                        Console.WriteLine("Your current position is:" + position);
                        Console.WriteLine("You encountered a ladder");
                        if ((position + player) > 100)
                        {
                            //StartPoint -= DiceRolled;
                            Console.WriteLine("Current position is:" + position);
                        }
                        //Console.WriteLine("Player Position : " + StartPoint);
                        //break;
                        //case snake:
                        //StartPoint -= DiceRolled;
                        //Console.WriteLine("Dice Rolls Value : -{0}", DiceRolled);
                        //Console.WriteLine("Snake Attack : " + StartPoint);

                        //if (StartPoint < 0)
                        else
                        {
                            //StartPoint = 0;
                            position = position + player;
                            Console.WriteLine("Player ladder moves ahead:" + position);
                        }
                        //Console.WriteLine("Player Position : " + StartPoint);
                        break;
                    case 3:
                        if (position > player)
                        {
                            position = position - player;
                        }
                        break;
                }
                //if(StartPoint == Winning)
                positionForPlayer1 = position;
                Console.WriteLine("player 1 dice count " + diceCountForPlayer1 + ": Position" + positionForPlayer1);
                diceCountForPlayer2++;
                switch (Option)
                {
                    //Console.WriteLine("Won");
                    //Console.WriteLine(" Num of times dice rolled : {0}", +Count);
                    //Console.WriteLine("======PLAYER WON======");
                    //Console.WriteLine("*****GAME END*****");
                    case 0:
                    case 1:
                        Console.WriteLine("Player stay at the same position");
                        break;

                    case 2:
                        Console.WriteLine("Your current position is:" + position);
                        Console.WriteLine("You encountered a ladder");
                        if ((position + player) > 100)
                        {
                            Console.WriteLine("Current position is:" + position);
                        }
                        else
                        {
                            position = position + player;
                            Console.WriteLine("Player ladder moves ahead:" + position);
                        }
                        break;

                    case 3:
                        if (position > player)
                        {
                            position = position - player;
                        }
                        break;
                }
                positionForPlayer2 = position;
                Console.WriteLine("player 2 die count" + diceCountForPlayer2 + ": Position" + positionForPlayer2);
            }
            if (positionForPlayer1 == WINNING_POSITION)
            {
                Console.WriteLine("Player1 won the game, You rolled the die " + diceCountForPlayer1 + " times");
            }
            else
            {
                Console.WriteLine("Player2 won the game, You rolled the die " + diceCountForPlayer2 + " times");
            }


        }
            
            
    }
            
        
}
        
 
    
