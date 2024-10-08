using System;

namespace Helloworld
{
    class Positive_Negative
    {
        public static void Main(String[] args)
        {
            int n,pos=0,neg=0;
            n=Convert.ToInt32(Console.ReadLine());
            int[] a=new int[n];
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
                if(a[i]>=0)
                {
                    pos++;
                }
                else
                {
                    neg++;
                }
            }
            Console.WriteLine("Positive numbers:"+pos);
            Console.WriteLine("Negative numbers:"+neg);
            
        }
    }
}