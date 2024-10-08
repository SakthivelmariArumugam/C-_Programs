using System;

namespace Helloworld
{
    class Bill
    {
        public static void Main(String[] args)
        {
            int bno,qty;
            string cust,item;
            float rate,amt,tax,disc,netamt;
            Console.WriteLine("Bill no:");
            bno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Customer");
            cust=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Item:");
            item=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Rate:");
            rate=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("quantity");
            qty=Convert.ToInt32(Console.ReadLine());
            amt=rate*qty;
            tax=amt*7/100;
            disc=amt*13/100;
            netamt=amt+tax-disc;
            Console.WriteLine("Bill details");
            Console.WriteLine("Costumer:"+cust);
            Console.WriteLine("Item:"+item);
            Console.WriteLine("Rate:"+rate);
            Console.WriteLine("Quantity:"+qty);
            Console.WriteLine("Amount:"+amt);
            Console.WriteLine("tax:"+tax);
            Console.WriteLine("discount:"+disc);
            Console.WriteLine("netamount:"+netamt);
            
            
        }
    }
}