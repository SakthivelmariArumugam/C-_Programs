using System;

namespace Helloworld
{
    class Perfect
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n=Convert.ToInt32(Console.ReadLine());
            
            int sum=0;
            for(int i=1;i<=n/2;i++)
            {
                if(n%i==0)
                {
                    sum=sum+i;
                }
            }
            if(sum==n)
            {
                Console.WriteLine("Perfect Number");
            }
            else
            {
                Console.WriteLine("Not Perfect Number");
            }
        }
    }
}