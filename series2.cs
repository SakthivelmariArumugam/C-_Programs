using System;

namespace Helloworld
{
    class Hello
    {
        public static void Main(String[] args)
        {
            int n,s=0;
            Console.WriteLine("Enter Your Number:");
            n=Convert.ToInt32(Console.ReadLine());
            
            for(int i=1;i<=n;i++)
            {
                if(i%2==0)
                {
                  s=s+i;
                  Console.WriteLine(i);
                }
            }
            Console.WriteLine("The Sum Value:"+s);
        }
    }
}