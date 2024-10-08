using System;

namespace Helloworld
{
    class Small
    {
        public static void Main(String[] args)
        {
            int n;
            n=Convert.ToInt32(Console.ReadLine());
            int[] a=new int[n];
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            int small=a[0];
            for(int i=0;i<a.Length;i++)
            {
                if(a[i]<small)
                {
                    small=a[i];
                }
            }
            Console.WriteLine("The Small Value is:"+small);
        }
    }
}