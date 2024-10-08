using System;

namespace Helloworld
{
    class letter_pattern_2
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write((char)(64+j)+" ");
                }
                Console.WriteLine();
            }
        }
    }
}