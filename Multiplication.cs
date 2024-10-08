using System;

namespace Helloworld
{
    class Multiplication
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the Number:");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=10;i++)
            {
                Console.WriteLine(i+"*"+n+"="+(i*n));
            }
        }
    }
}