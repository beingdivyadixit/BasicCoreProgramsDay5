using System;

namespace BasicCoreProgramsDay5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Number of times you wanted to flip the coin");
            int N= Convert.ToInt32(Console.ReadLine()); // stored user input by converting data typ into int
            flipCoin.coinFlip(N);  //class.method
        }
    }
}
