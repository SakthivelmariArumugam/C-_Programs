using System;

namespace Helloworld
{
    class Employee
    {
        public static void Main(String[] args)
        {
            int employeeno;
            string name,design;
            float basic,da,ma,ta,hra,gpay,epf,lic,loan,deduct,netpay;
            
            Console.WriteLine("Enter The Employee no:");
            employeeno=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name:");
            name=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Design:");
            design=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the Basic Salary:");
            basic=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the dearness allowance:");
            da=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Medical allowance:");
            ma=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Travelling allowance:");
            ta=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Houser Rent allowance:");
            hra=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the Epf amount:");
            epf=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the lic:");
            lic=Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Enter the loan:");
            loan=Convert.ToSingle(Console.ReadLine());
            gpay=basic+da+ta+ma+hra;
            deduct=epf+lic+loan;
            netpay=gpay-deduct;
            Console.WriteLine("The Employee no:"+employeeno);
            Console.WriteLine("The Employee Name:"+name);
            Console.WriteLine("the Employee Design:"+design);
            Console.WriteLine("The Gpay amount:"+gpay);
            Console.WriteLine("The deduct amount:"+deduct);
            Console.WriteLine("The NetPay Amount:"+netpay);
        }
    }
    
}