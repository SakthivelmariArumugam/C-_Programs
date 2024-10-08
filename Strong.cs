using System;

namespace Helloworld
{
    class Strong
    {
        public static int fun(int a)
        {
            int sum=1;
            for(int i=1;i<=a;i++)
            {
                sum=sum*i;
            }
            return sum;
        }
        public static void Main(String[] args)
        
        {
            int n;
            Console.WriteLine("Enter the Number:");
            n=Convert.ToInt32(Console.ReadLine());
            int value=n;
            int sum=0;
            while(n>0)
            {
                int l=n%10;
                sum=sum+fun(l);
                n=n/10;
            }
            if(sum==value)
            {
                Console.WriteLine("Strong Number");
            }
            else
            {
                Console.WriteLine("Not a Strong Number");
            }
            
        }
    }
}