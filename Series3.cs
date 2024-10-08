using System;

namespace Helloworld
{
    class Series3
    {
        public static void Main(String[] args)
        {
            int n,s=0;
            Console.WriteLine("Enter the number:");
            n=Convert.ToInt32(Console.ReadLine());
            
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine(i);
                int t=i*i;
                s=s+t;
            }
            Console.WriteLine("The Sum value:"+s);
        }
    }
}