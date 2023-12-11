using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ROCKPAPERSCISSOR{

    class Program{
        static void Main(string[] args){
            String inputPlayer, inputCPU;
            int randomInt;
            bool playAgain = true;

            while(playAgain){

                int scorePlayer = 0;
                int scoreCPU = 0;

            while(scorePlayer < 3 && scoreCPU < 3)
            {

            Console.Write("Choose between ROCK, PAPER and SCISSORS:  ");
            inputPlayer = Console.ReadLine();
            inputPlayer = inputPlayer.ToUpper();

            Random rnd = new Random();
            randomInt = rnd.Next(1, 4);

            switch(randomInt){
                case 1:
                    inputCPU = "ROCK";
                    Console.WriteLine("Computer choose ROCK");
                    if(inputPlayer == "ROCK"){
                        Console.WriteLine("DRAW!! \n\n");
                    }
                    else if(inputPlayer == "PAPER"){
                        Console.WriteLine("PLAYER WINS! \n\n");
                        scorePlayer++;
                    }
                    else if(inputPlayer == "SCISSORS"){
                        Console.WriteLine("CPU WINS! \n\n");
                        scoreCPU++;
                    }
                    break;
                case 2:
                    inputCPU = "PAPER";
                    Console.WriteLine("Computer choose PAPER");
                    if(inputPlayer == "PAPER"){
                        Console.WriteLine("DRAW!! \n\n");
                    }
                    else if(inputPlayer == "ROCK"){
                        Console.WriteLine("CPU WINS! \n\n");
                        scoreCPU++;
                    }
                    else if(inputPlayer == "SCISSORS"){
                        Console.WriteLine("PLAYER WINS! \n\n");
                        scorePlayer++;
                    }
                    break;
                case 3:
                    inputCPU = "SCISSORS";
                    Console.WriteLine("Computer choose SCISSORS");
                    if(inputPlayer == "SCISSORS"){
                        Console.WriteLine("DRAW!! \n\n");
                    }
                    else if(inputPlayer == "ROCK"){
                        Console.WriteLine("PLAYER WINS! \n\n");
                        scorePlayer++;
                    }
                    else if(inputPlayer == "PAPER"){
                        Console.WriteLine("CPU WINS! \n\n");
                        scoreCPU++;
                    }
                    break;
                default:
                    Console.WriteLine("INVALID ENTRY.");
                    break;
                }

                Console.WriteLine("\n\nSCORES: \tPLAYER:\t{0}\tCPU:\t{1}", scorePlayer, scoreCPU);
            } 
            
            if(scorePlayer == 3){
                Console.WriteLine("Player WINS!");
            }
            else if(scoreCPU == 3){
                Console.WriteLine("CPU WINS!");
            }

            Console.WriteLine("Do you want to Play Again?(Y/N)");

            String loop = Console.ReadLine();
            if(loop == "Y"){
                playAgain = true;
                Console.Clear();
            }
            else if(loop == "N"){
                playAgain = false;
            }
            
         }
      }
    }
}