using System;

namespace Helloworld
{
    class Odd_Even
    {
        public static void Main(String[] args)
        {
            int n,odd=0,even=0;
            n=Convert.ToInt32(Console.ReadLine());
            int[] a=new int[n];
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
                if(a[i]%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("Odd Count:"+odd);
            Console.WriteLine("Even Count:"+even);
        }
    }
}