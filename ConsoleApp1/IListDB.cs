using System.Collections.Generic;

namespace ConsoleApp1
{
    interface IListDB
    {
        List<ICustomer> CustomerList { get; set; }
        List<IService> ServiceList { get; set; }
    }
}