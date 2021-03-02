using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FluentInterface.Contracts
{
    public interface ICustomer
    {
        int ID { get; set; }
        string CustomerName { get; set; }
        string CustomerAddress { get; set; }
        DateTime CreateDate { get; set; }
        DateTime ModifiedDate { get; set; }
        bool IsDeleted { get; set; }
    }
}
