using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgramsDay5
{
    internal class leapYear
    {
        public static void yearLeap(int Year)
        {  //if & else if statement for checking year is leap or not
            if (Year%400==0) 
            {
                Console.WriteLine("it's Leap Year"); 
            }
            else if(Year%100==0)
            {
                Console.WriteLine("it's not a Leap Year");
            }
            else if(Year%4==0) { }
            {
                Console.WriteLine("it's Leap Year");
            }
        }
    }
}
