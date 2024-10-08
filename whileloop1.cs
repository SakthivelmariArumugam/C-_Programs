using System;

namespace Helloworld
{
    class Hello
    {
        public static void Main(String[] args)
        {
            int n,s=0;
            Console.WriteLine("Enter the number:");
            n=Convert.ToInt32(Console.ReadLine());
            
            int i=1;
            while(i<=n)
            {
                if(i%2!=0)
                {
                    Console.WriteLine(i);
                    s=s+i;
                }
                i++;
            }
            Console.WriteLine("The Sum Value:"+s);
        }
    }
}