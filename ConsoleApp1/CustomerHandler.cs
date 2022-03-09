using System;
using System.Collections.Generic;
namespace ConsoleApp1
{
    class CustomerHandler : ICustomerHandler
    {
        private readonly Customer.Factory customerFactory;
        public IListDB ListDB { get; set; }
        public CustomerHandler(IListDB listDB, Customer.Factory customerFactory)
        {
            this.customerFactory = customerFactory;
            ListDB = listDB;            
        }
        public void RegisterCustomer()
        {
            Console.WriteLine("Vad heter kunden som ska registreras?");
            string customerName = Console.ReadLine();
            var customer = customerFactory(customerName);
            ListDB.CustomerList.Add(customer);
        }
        public void DisplayCustomers()
        {
            foreach (var Customer in ListDB.CustomerList)
            {
                Console.WriteLine(Customer.Name);
            }
        }
    }
}
