using System;

namespace Helloworld
{
    class if_condition
    {
        public static void Main(String[] args)
        {
            int x,y;
            x=Convert.ToInt32(Console.ReadLine());
            y=Convert.ToInt32(Console.ReadLine());
            
            if(x>y)
            {
                Console.WriteLine("X is biggest");
            }
            else
            {
                Console.WriteLine("Y is biggest");
            }
        }
    }
}