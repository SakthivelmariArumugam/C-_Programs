using System;

namespace Helloworld
{
    class If_condition2
    {
        public static void Main(String[] args)
        {
            int n=Convert.ToInt32(Console.ReadLine());
            if(n>=0)
            {
                Console.WriteLine("Positive");
            }
            else
            {
                Console.WriteLine("Negative");
            }
        }
    }
}