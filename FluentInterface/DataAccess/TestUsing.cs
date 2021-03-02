using Design_Patterns.FluentInterface.Entities;
using Design_Patterns.FluentInterface.Operations;
using System;
using System.Collections.Generic;
using System.Text;

namespace Design_Patterns.FluentInterface.DataAccess
{
    public class TestUsing
    {
        public TestUsing()
        {
            //CTOR
        }

        public void AddNewCustomer(Customer customer)
        {
            Customer customerinfo = CustomerManager<Customer>
                                                                    .initialize(new Customer())
                                                                    .GiveAvalue(t => t.CustomerName, customer.CustomerName)
                                                                    .GiveAvalue(t => t.ID, customer.ID)
                                                                    .GiveAvalue(t => t.CustomerAddress, customer.CustomerAddress)
                                                                    .GiveAvalue(t => t.CreateDate, DateTime.Now)
                                                                    .GiveAvalue(t => t.ModifiedDate, DateTime.Now)
                                                                    .GiveAvalue(t => t.IsDeleted, false)
                                                                    .Take();
        }
    }
}
