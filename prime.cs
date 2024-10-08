using System;

namespace HelloWorld
{
    class Hello
    {
        public static void Main(String[] args)
        {
            int n;
            bool s=true;
            Console.WriteLine("Enter the number:");
            n=Convert.ToInt32(Console.ReadLine());
            if(n<=1)
            {
                Console.WriteLine("The number not a prime and composite number");
            }
            else if(n==2)
            {
                Console.WriteLine("The Number is Prime number");
            }
            else
            {
                if(n%2==0)
                {
                    s=false;
                }
                else
                {
                for(int i=3;i<=Math.Sqrt(n);i+=2)
                {
                    if(n%i==0)
                    {
                        s=false;
                        break;
                    }
                }
                }
                if(s==true)
                {
                    Console.WriteLine("The number is prime");
                }
                else
                {
                    Console.WriteLine("The number is not prime");
                }
            }
        }
    }
}