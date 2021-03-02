using Design_Patterns.FluentInterface.Contracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace Design_Patterns.FluentInterface.Operations
{
   public  class CustomerOperations<T> : ICustomerOperation<T>
    {
        T _instance;
        public CustomerOperations(T instance)
        {
            _instance = instance;
        }

        public ICustomerOperation<T> GiveAvalue(Expression<Func<T, object>> Property, object Value)
        {
            PropertyInfo pInfo = null;

            if (Property.Body is MemberExpression)
            {
                pInfo = (Property.Body as MemberExpression).Member as PropertyInfo;

            }
            else
            {
                pInfo = (((UnaryExpression)Property.Body).Operand as MemberExpression).Member as PropertyInfo;
            }

            pInfo.SetValue(_instance, Value);
            return this;
        }

        public T Take()
        {
            return _instance;
        }
    }

    static class CustomerManager<T>
    {
        public static ICustomerOperation<T> initialize(T instance)
        {
            return new CustomerOperations<T>(instance);
        }
    }
}
