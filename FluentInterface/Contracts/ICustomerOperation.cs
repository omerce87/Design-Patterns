using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Design_Patterns.FluentInterface.Contracts
{
    public interface ICustomerOperation<T>
    {
        ICustomerOperation<T> GiveAvalue(Expression<Func<T, object>> Property, object Value);
        T Take();
    }
}
