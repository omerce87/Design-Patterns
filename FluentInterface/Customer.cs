using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;

namespace API__Library.DesignPatterns.FluentInterface
{
    public class CustomerProps {
        public int ID { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public DateTime CreateDate { get; set; }
        public DateTime ModifiedDate { get; set; }
        public bool IsDeleted { get; set; }

    }

    public class Customer<T> : ICustomer<T>
    {
        T _instance;
        public Customer(T instance)
        {
            _instance = instance;
        }

        public ICustomer<T> GiveAvalue(Expression<Func<T, object>> Property, object Value)
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
        public static ICustomer<T> initialize(T instance)
        {
            return new Customer<T>(instance);
        }
    }
}
