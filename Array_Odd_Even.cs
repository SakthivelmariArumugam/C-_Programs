using System;

namespace Helloworld
{
    class Array2
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the Number:");
            n=Convert.ToInt32(Console.ReadLine());
            int[] a=new int[n];
            for(int i=0;i<n;i++)
            {
                a[i]=Convert.ToInt32(Console.ReadLine());
            }
            int odd=0;
            int even=0;
            for(int i=0;i<n;i++)
            {
                if(a[i]%2==0)
                {
                    even++;
                }
                else
                {
                    odd++;
                }
            }
            Console.WriteLine("The Odd count:"+odd);
            Console.WriteLine("The Even count:"+even);
        }
    }
}