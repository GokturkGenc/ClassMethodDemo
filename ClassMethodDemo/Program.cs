using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {

            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(1, "göktürk", 21);
            customerManager.Add(2, "mehmet", 28);
            customerManager.Add(3, "veli", 29);
            customerManager.Add(4, "mustafa", 37);
            customerManager.Add(5, "ayhan", 33);


            customerManager.ShowCustomers();


            Console.ReadLine();

        }
    }
}
