using System;

namespace Helloworld
{
    class big
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter Th number:");
            n=Convert.ToInt32(Console.ReadLine());
            int[] a=new int[n];
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            int big=a[0];
            for(int i=0;i<n;i++)
            {
                if(a[i]>big)
                {
                    big=a[i];
                }
            }
            Console.WriteLine("The Biggest Number is:"+big);
        }
    }
}