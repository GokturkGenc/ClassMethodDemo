using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {
        List<Customer> customers = new List<Customer>();

        public void Add(int id, string name, int age)
        {
            customers.Add(new Customer()
            {
                Id = id,
                Name = name,
                Age = age,
            });

        }

        public void ShowCustomers()
        {
            Console.WriteLine("Kayıtlı Müşterilerimiz:");
            Console.WriteLine("Musteri No \t İsmi \t Yaşi");
            foreach (Customer customs in customers)
            {
                Console.WriteLine("\n");
                Console.WriteLine(customs.Id + " \t " + customs.Name + " \t " + customs.Age);
            }
        }
    }
}