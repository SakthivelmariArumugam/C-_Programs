using System;

namespace Helloworld
{
    class Array1
    {
        public static void Main(String[] args)
        {
        int[] a=new int[50];
        int sum=0;
        for(int i=0;i<10;i++)
        {
            a[i]=Convert.ToInt32(Console.ReadLine());
            sum=sum+a[i];
        }
        Console.WriteLine("The Sum Value is:"+sum);
        }
    }
}