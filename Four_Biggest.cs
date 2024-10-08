using System;

namespace Helloworld
{
    class Nested_Condition
    {
        public static void Main(String[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            int b=Convert.ToInt32(Console.ReadLine());
            int c=Convert.ToInt32(Console.ReadLine());
            
            if(a<b)
            {
                if(a<c)
                {
                    Console.WriteLine("A is Smallest");
                }
                else
                {
                    Console.WriteLine("C is Smallest");
                }
            }
            else
            {
                if(b<c)
                {
                    Console.WriteLine("b is smallest");
                }
                else
                {
                    Console.WriteLine("C is smallest");
                }
            }
        }
    }
}