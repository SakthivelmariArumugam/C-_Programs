using System;

namespace Helloworld
{
    class Hello
    {
        public static void Main(String[] args)
        {
            int a=0,b=1;
            Console.Write(a+" "+b+" ");
            for(int i=3;i<=10;i++)
            {
                int sum=a+b;
                Console.Write(sum+" ");
                a=b;
                b=sum;
                
            }
        }
    }
}