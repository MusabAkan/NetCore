using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetCore
{
    public interface ICustomerRepository
    {
        void Add(Customer entity);
        IEnumerable<Customer> GetAllActive();

    }
}
