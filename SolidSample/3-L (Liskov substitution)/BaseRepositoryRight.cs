using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidSample._2_O
{
    public interface IWritableRepository<T>
    {
        void Save(T entity);
    }

    public interface IReadableRepository<T>
    {
        T Get(int id);
    }

    public class CustomerRepository2 : IWritableRepository<Customer>, IReadableRepository<Customer>
    {
        public void Save(Customer entity)
        {
            // save entity to the database
        }

        public Customer Get(int key)
        {
            return new Customer();
        }
    }

    public class StreetRepository2 : IReadableRepository<Street>
    {
        public Street Get(int key)
        {
            return new Street();
        }
    }
}
