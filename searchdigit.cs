using System;

namespace Helloworld
{
    class Search
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n=Convert.ToInt32(Console.ReadLine());
            int s;
            Console.WriteLine("Enter search number");
            s=Convert.ToInt32(Console.ReadLine());
            bool result=false;
            while(n>0)
            {
                int l=n%10;
                if(l==s)
                {
                    result=true;
                    break;
                }
                n=n/10;
            }
            if(result==true)
            {
                Console.WriteLine("Digit present");
            }
            else
            {
                Console.WriteLine("Digit is not Present");
            }
        }
    }
}