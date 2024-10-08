using System;

namespace Helloworld
{
    class Series4
    {
        public static void Main(String[] args)
        {
            int n,s=1;
            Console.WriteLine("Enter the number:");
            n=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=n;i++)
            {
                Console.WriteLine(i);
                s=s*i;
            }
            Console.WriteLine("The Multiple Value:"+s);
        }
    }
}