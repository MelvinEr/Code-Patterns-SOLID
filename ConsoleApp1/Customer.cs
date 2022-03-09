using System.Collections.Generic;

namespace ConsoleApp1
{
    public class Customer : ICustomer
    {
        public Customer(string Name)
        {
            this.Name = Name;
            Pets = new();
        }
        public delegate Customer Factory(string Name);
        public string Name { get; set; }
        public List<IPet> Pets { get; set; }
        public string Receipt { get; set; } = "Kvitto\n";
        public int Total { get; set; } = 0;
    }
}
