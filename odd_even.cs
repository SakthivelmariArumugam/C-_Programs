using System;

namespace Helloworld
{
    class if_condition3
    {
        public static void Main(String[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            if(n%2==0)
            {
                Console.WriteLine("Even Number");
            }
            else
            {
                Console.WriteLine("Odd Number");
            }
        }
    }
}