using Design_Patterns.FluentInterface.Contracts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FluentInterface.Entities
{
    public class Customer : ICustomer
    {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }
    }
}
