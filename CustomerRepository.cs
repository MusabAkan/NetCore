 
namespace NetCore
{
    public  interface IRepository<T>
    {
        void Add(T entity);
        IEnumerable<T> GetAll();

    }

    public class CustomerRepository : IRepository<Customer>, ICustomerActions
    {
        private List<Customer> customers;

        public CustomerRepository()
        {
            customers = new List<Customer>();
        }
        public void Add(Customer entity)
        {
            if (customers.Any(c => c.Id == entity.Id))
                throw new Exception("Duplicated ID");
            customers.Add(entity);
        }

        public IEnumerable<Customer> GetAll()
        {
            return customers.ToList();
        }

        public void ArchiveCustomer(Customer customer)
        {
            throw new NotImplementedException();
        }
    }
}
