using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadderProblem
{
    public class Player2
    {
        public static int Play2()
        {
            int Start_Position = 0, r = 0, choice = 0, count = 0;
            const int NOPLAY = 0;
            const int LADDER = 1;
            const int SNAKE = 2;
            Random random = new Random();//Random function to generate random number
            while (Start_Position < 100)
            {
                r = random.Next(1, 7);//Giving range from 1 to 6
                choice = random.Next(0, 3);
                switch (choice)
                {
                    case NOPLAY:
                        //Console.WriteLine("Position: {0} NoPlay", Start_Position);
                        break;
                    case LADDER:
                        Start_Position = Start_Position + r;
                        if (Start_Position > 100)
                            Start_Position = Start_Position - r;
                        break;
                    case SNAKE:
                        Start_Position = Start_Position - r;
                        if (Start_Position < 0)
                        {
                            Start_Position = 0;
                        }
                        break;
                }
                count++;//Increamenting loop

            }
            return count;
            Console.WriteLine("Number of times the dice was played by Player 2: {0}", count);
        }
    }
}
