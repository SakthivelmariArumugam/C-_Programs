using System;

namespace Helloworld
{
    class Reverse
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
            Console.WriteLine("Before Reverse the array");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            int l=0;
            int k=a.Length-1;
            while(l<k)
            {
                int temp=a[l];
                a[l]=a[k];
                a[k]=temp;
                l++;
                k--;
            }
            Console.WriteLine();
              Console.WriteLine("After Reverse the array");
            for(int i=0;i<a.Length;i++)
            {
                Console.Write(a[i]+" ");
            }
            
        }
    }
}