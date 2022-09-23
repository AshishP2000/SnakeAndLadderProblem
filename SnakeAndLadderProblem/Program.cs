using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-7 Play the game with 2 player
            int player1 = 0,player2=0;
          
            //Player1 player1 = new Player1();
            Player2 player21 = new Player2();
            player1=Player1.Play1();//storing count in player1 variable
            
            Thread.Sleep(50);//It is to pause program for some time
            player2 = Player2.Play2();//storing count in player2 variable

            if (player1 < player2)//Comparing 2 values
                Console.WriteLine("Player 1 Wins");
            else
                Console.WriteLine("Player 2 Wins");

            Console.ReadLine();
        }
    }
}
