using System.Collections.Generic;

namespace ConsoleApp1
{
    class ListDB : IListDB
    {
        public ListDB()
        {
            CustomerList = new();
            ServiceList = new();
        }
        public List<ICustomer> CustomerList { get; set; }
        public List<IService> ServiceList { get; set; }
    }
}
