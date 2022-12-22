using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class flipCoin
    {
        public static void coinFlip(int N)
        {
            int TailsCount = 0, HeadCount = 0;
            Random random = new Random();
            for(int i=0; i<N; i++)
            {
                double FlipCoin = random.NextDouble();
                if(FlipCoin<0.5)
                {
                    TailsCount = TailsCount + 1;
                    Console.WriteLine("It's Tails");
                }
                else
                {
                    HeadCount = HeadCount + 1;
                    Console.WriteLine("It's Head");
                }
            }
            double PercentageOfHead = (HeadCount * 100)/N;
            double PercentageOfTails = (TailsCount * 100)/N;
            Console.WriteLine("Head came : {0} , Tails came : {1} , Percentage of Head : {2}% & Percentage of Tails : {3}% ",HeadCount,TailsCount,PercentageOfHead,PercentageOfTails);
        }
    }
}
