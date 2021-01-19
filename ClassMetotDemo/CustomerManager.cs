using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    public class CustomerManager
    {
        private List<Customer> customers = null;
        private int id;
        private List<Customer> CreateSampleCustomerList()
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer { Id = 1, FirstName = "Ali", LastName = "Gunduz", PhoneNumber = "34592232", Address = "istanbul" });
            customers.Add(new Customer { Id = 2, FirstName = "Hasan", LastName = "Aksu", PhoneNumber = "35545", Address = "istanbul" });
            customers.Add(new Customer { Id = 3, FirstName = "Huseyin", LastName = "Kartal", PhoneNumber = "4534534", Address = "istanbul" });
            customers.Add(new Customer { Id = 4, FirstName = "Selim", LastName = "Kapukulu", PhoneNumber = "3453434", Address = "istanbul" });
            customers.Add(new Customer { Id = 5, FirstName = "Meryem", LastName = "Kocagoz", PhoneNumber = "2342423", Address = "istanbul" });
            customers.Add(new Customer { Id = 6, FirstName = "Elif", LastName = "Inci", PhoneNumber = "45645645", Address = "istanbul" });
            customers.Add(new Customer { Id = 7, FirstName = "Ebru", LastName = "Nice", PhoneNumber = "5465776", Address = "istanbul" });
            customers.Add(new Customer { Id = 8, FirstName = "Ece", LastName = "Guven", PhoneNumber = "678768678", Address = "istanbul" });
            customers.Add(new Customer { Id = 9, FirstName = "Eren", LastName = "Cennet", PhoneNumber = "6786799", Address = "istanbul" });
            customers.Add(new Customer { Id = 10, FirstName = "Melik", LastName = "Arslan", PhoneNumber = "8989089", Address = "istanbul" });
             
            return customers;
             
        }
        public void Add(Customer customer)
        {
            customer.Id = id;
            customers.Add(customer);
            id++;

            Console.WriteLine("Congratulations! Customer Added : {0} {1} ", customer.FirstName, customer.LastName );
        }

        public CustomerManager()
        {
            customers = CreateSampleCustomerList();
            id = 11;
        }
        public void List()
        {
            //List<Customer> customers = CreateSampleCustomerList();
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Id = {0}\nFirstName = {1}\nLastName = {2}\nPhoneNumber = {3}\nAddress = {4} ",
                                customer.Id, customer.FirstName, customer.LastName, customer.PhoneNumber, customer.Address);
                //\n  it's mean  new Line
                Console.WriteLine("----------------------------------------------------------------");
            }
        }

        public void Delete(Customer customer)
        {
            customers.Remove(customer);
            Console.WriteLine("Customer Deleted : {0} {1} ", customer.FirstName, customer.LastName);
        }
    }
}
