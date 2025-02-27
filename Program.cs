using System;

namespace Application
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to islam's carpet cleaning center");
            Console.WriteLine("Enter the number of small carpets");
            int smallnumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the number of large carpets");
            int largenumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("price of small carpets is 25 $\n");
            Console.WriteLine("price of large carpets is 35 $\n"); 
            int total = (smallnumber * 25) + (largenumber * 35);
            double tax = total * 0.6;
            Console.WriteLine($"the totoal amount is {total}$\n");
            Console.WriteLine($"the tax applied is {tax}$\n");
            Console.WriteLine("==========================================");
            double totalestimate = total + tax;
            Console.WriteLine($"The total estimate is {totalestimate} $ ");
            Console.WriteLine("This estimate is available only for 30 days");


        }
    }
}