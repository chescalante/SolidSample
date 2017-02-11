using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolidSample._2_O
{
    public interface IBaseRepository<T>
    {
        void Save(T entity);
        T Get(int id);
    }

    public class CustomerRepository : IBaseRepository<Customer>
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

    public class StreetRepository : IBaseRepository<Street>
    {
        public void Save(Street entity)
        {
            throw new Exception("Streets are read only.");
        }

        public Street Get(int key)
        {
            return new Street();
        }
    }
}
