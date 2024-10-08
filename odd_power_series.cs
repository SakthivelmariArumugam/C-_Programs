using System;

namespace Helloworld
{
    class odd_power_series
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the number:");
            n=Convert.ToInt32(Console.ReadLine());
            int flag=1;
            int sum=0;
            for(int i=1;i<=n;i+=2)
            {
                if(flag==1)
                {
                    int l=i*i;
                    sum=sum+l;
                    flag=0;
                }
                else
                {
                    sum=sum+i;
                    flag=1;
                }
            }
            Console.WriteLine("The Sum value:"+sum);
            
        }
    }
}