using System;

namespace Helloworld
{
    class Hello
    {
        public static void Main(String[] args)
        {
            int n;
            Console.WriteLine("Enter the number");
            n=Convert.ToInt32(Console.ReadLine());
            int i=1;
            int sum=0;
            while(i<=n)
            {
                Console.WriteLine(i);
                sum=sum+(i*i);
                i++;
            }
            Console.WriteLine("The Sum:"+sum);
        }
    }
}