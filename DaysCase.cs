using System;

namespace Helloworld
{
    class Days_switch
    {
        public static void Main(String[] args)
        {
            Console.WriteLine("Enter the Number:");
            int n=Convert.ToInt32(Console.ReadLine());
            switch(n)
            {
                case 1:
                Console.WriteLine("Sunday");
                break;
                case 2:
                Console.WriteLine("Monday");
                break;
                case 3:
                Console.WriteLine("Tuesday");
                break;
                case 4:
                Console.WriteLine("Wednesday");
                break;
                case 5:
                Console.WriteLine("Thursday");
                break;
                case 6:
                Console.WriteLine("Friday");
                break;
                case 7:
                Console.WriteLine("Saturday");
                break;
                default:
                Console.WriteLine("Enter only 1-7 numbers");
                break;
            }
        }
    }
}