using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Program
    {
        static void Main(string[] args)
        {
            //UC-4 Repeat till the player reaches the winning position 100
            int Start_Position = 0,r=0,choice=0,count=0;
            const int NOPLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            Random random = new Random();//Random function to generate random number
            while (Start_Position < 100)
            {
                r = random.Next(1, 7);//Giving range from 1 to 6
                //Console.WriteLine("Rolled Dice");
                Console.WriteLine("Number got: {0}", r);
                choice = random.Next(0, 3);
                Console.WriteLine("Player Choice: {0}", choice);
                switch (choice)
                {
                    case NOPLAY:
                        Console.WriteLine("Position: {0}", Start_Position);
                        break;
                    case LADDER:
                        Start_Position = Start_Position + r;
                        Console.WriteLine("Position: {0}", Start_Position);
                        break;
                    case SNAKE:
                        Start_Position = Start_Position - r;
                        if (Start_Position < 0)
                        {
                            Start_Position = 0;
                        }
                        Console.WriteLine("Position: {0}", Start_Position);
                        break;
                }

                count++;

            }
            Console.ReadLine();
        }
    }
}
