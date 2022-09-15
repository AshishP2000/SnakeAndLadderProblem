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
            //UC-2 Player Rolls a die to get number between 1 to 6
            int Start_Position = 0,r=0;
            Random random = new Random();//Random function to generate random number
            r = random.Next(1,7);//Giving range from 1 to 6
            Console.WriteLine("Rolled Dice");
            Console.WriteLine("Number got: {0}",r);



            Console.ReadLine();
        }
    }
}
