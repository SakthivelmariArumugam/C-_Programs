using System;

namespace Helloworld
{
    class Digit
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the number:");
            int n=Convert.ToInt32(Console.ReadLine());
            
            if(n<9 && n>0)
            {
                Console.WriteLine("One Digit Number");
            }
            else if(n>9 && n<100)
            {
                Console.WriteLine(" Two Digit Number");
            }
            else if(n>99 && n<1000)
            {
                Console.WriteLine("Three digit number");
            }
            else
            {
                Console.WriteLine("More than three digit number");
            }
        }
    }
}