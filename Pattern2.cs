using System;

namespace Helloworld
{
    class pattern2
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the number:");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                for(int j=n;j>=i;j--)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }
    }
}