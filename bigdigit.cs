using System;

namespace Helloworld
{
    class Big
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the Number:");
            n=Convert.ToInt32(Console.ReadLine());
            int big=n%10;
            while(n>0)
            {
                int l=n%10;
                if(l>big)
                {
                    big=l;
                }
                n=n/10;
            }
            Console.WriteLine("The Biggest Number is:"+big);
        }
    }
}