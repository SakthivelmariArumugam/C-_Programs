using System;

namespace Helloworld
{
    class Middle
    {
        public static void Main(String[] args)
        {
           int x=Convert.ToInt32(Console.ReadLine());
           int y=Convert.ToInt32(Console.ReadLine());
           int z=Convert.ToInt32(Console.ReadLine());
            
            if((x>y && x<z) || (x<y && x>z))
            {
                Console.WriteLine("x is Middle");
            }
            else if((y>x && y<z) || (y>z && y<x))
            {
                Console.WriteLine("y is middle");
            }
            else if((z>x && z<y) || (z>y && z<x))
            {
                Console.WriteLine("z is middle");
            }
            else
            {
                Console.WriteLine("No middle numbers");
            }
        }
    }
}