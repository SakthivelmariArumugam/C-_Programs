using System;

namespace Helloworld
{
    class Reverse
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter The Number:");
            n=Convert.ToInt32(Console.ReadLine());
            int value=n;
            int sum=0;
            while(n>0)
            {
                int l=n%10;
                sum=sum*10+l;
                n=n/10;
            }
            if(value==sum)
            {
                Console.WriteLine("Palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}