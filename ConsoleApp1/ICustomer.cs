using System.Collections.Generic;

namespace ConsoleApp1
{
    public interface ICustomer
    {
        string Name { get; set; }
        List<IPet> Pets { get; set; }
        string Receipt { get; set; }
        int Total { get; set; }
    }
}