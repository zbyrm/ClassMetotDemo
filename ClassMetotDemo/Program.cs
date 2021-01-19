///*********************************
///Demo program ziya 

using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 1;
            customer1.FirstName = "Ahmet";
            customer1.LastName = "Deniz";
            customer1.PhoneNumber = "032344488";
            customer1.Address = "İstanbul";

            Customer customer2 = new Customer();
            customer2.Id = 1;
            customer2.FirstName = "Fatma";
            customer2.LastName = "Ay";
            customer2.PhoneNumber = "0374361";
            customer2.Address = "İstanbul";

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

            Console.WriteLine("----------Customer List-----------------------------------------------");
            customerManager.List();

            customerManager.Delete(customer1);

            Console.WriteLine("----------Customer List After Deleted Record------------------------------------------");
            customerManager.List();
        }
    }
}
