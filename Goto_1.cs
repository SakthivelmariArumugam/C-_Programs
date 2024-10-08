using System;

namespace Helloworld
{
    class Goto_1
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the numbers:");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                if(i==5)
                {
                    goto Hello;
                }
                Console.WriteLine(i);
            }
            Hello:
            Console.WriteLine("The Code Is End");
            
        }
    }
}