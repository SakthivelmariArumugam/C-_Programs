using System;

namespace Helloworld
{
    class Pattern3
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the Number:");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=i;j>=1;j--)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}