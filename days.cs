using System;

namespace Helloworld
{
    class Days
    {
        public static void Main(String[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            
            if(n==1)
            {
                Console.WriteLine("Sunday");
            }
            else if(n==2)
            {
                Console.WriteLine("Monday");
            }
            else if(n==3)
            {
                Console.WriteLine("Tuesday");
            }
            else if(n==4)
            {
                Console.WriteLine("Wednesday");
            }
            else if(n==5)
            {
                Console.WriteLine("Thursday");
            }
            else if(n==6)
            {
                Console.WriteLine("Friday");
            }
            else if(n==7)
            {
                Console.WriteLine("Saturday");
            }
            else
            {
                Console.WriteLine("Enter only 1-7 numbers");
            }
        }
    }
}