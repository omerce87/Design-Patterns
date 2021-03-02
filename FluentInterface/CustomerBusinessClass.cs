using System;
using System.Collections.Generic;
using System.Text;

namespace API__Library.DesignPatterns.FluentInterface
{
    class CustomerBusinessClass
    {
        public CustomerBusinessClass()
        {

        }

        public void addNewCustomer(CustomerProps customer)
        {
            CustomerProps customerinfo = CustomerManager<CustomerProps>
                                                                    .initialize(new CustomerProps())
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
