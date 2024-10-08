using System;

namespace Helloworld
{
    class Sum_of_digit
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the number:");
            n=Convert.ToInt32(Console.ReadLine());
            int sum=0;
            while(n>0)
            {
                int l=n%10;
                sum=sum+l;
                n=n/10;
            }
            Console.WriteLine("The Sum Of Digit:"+sum);
        }
    }
}