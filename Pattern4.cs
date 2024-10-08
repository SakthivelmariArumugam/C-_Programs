using System;

namespace Helloworld
{
    class Pattern4
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the Number:");
            n=Convert.ToInt32(Console.ReadLine());
            int count=1;
            for(int i=1;i<=n;i++)
            {
                for(int j=1;j<=i;j++)
                {
                    Console.Write(count+" ");
                    count++;
                }
                Console.WriteLine();
            }
        }
    }
}