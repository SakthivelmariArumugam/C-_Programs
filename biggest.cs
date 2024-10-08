using System;

namespace Helloworld
{
    class if_condition3
    {
        public static void Main(String[] args)
        {
            int x=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            int z=Convert.ToInt32(Console.ReadLine());
            
            if(x>y && x>z)
            {
                Console.WriteLine("x is biggest");
            }
            else if(y>x && y>z)
            {
                Console.WriteLine("y is biggest");
            }
            else
            {
                Console.WriteLine("z is biggest");
            }
        }
    }
}