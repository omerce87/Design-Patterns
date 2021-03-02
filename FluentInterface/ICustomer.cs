using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace API__Library.DesignPatterns.FluentInterface
{
    public interface ICustomer<T>
    {
        ICustomer<T> GiveAvalue(Expression<Func<T, object>> Property, object Value);
        T Take();
    }

}
