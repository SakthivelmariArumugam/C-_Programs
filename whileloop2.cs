using System;

namespace Helloworld
{
    class Hello
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the number:");
            n=Convert.ToInt32(Console.ReadLine());
            int i=1;
            int sum=0;
            while(i<=n)
            {
                if(i%2==0)
                {
                    Console.WriteLine(i);
                    sum=sum+i;
                }
                i++;
            }
            Console.WriteLine("the sum:"+sum);
        }
    }
}