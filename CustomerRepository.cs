 
namespace NetCore
{
    

    public class CustomerRepository : ICustomerRepository 
    {
        private List<Customer> customers;

        public CustomerRepository()
        {
            customers = new List<Customer>();
        }
        public void Add(Customer entity)
        {
            customers.Add(entity);
        }

        public IEnumerable<Customer> GetAllActive()
        {
            return customers.Where(x => x.IsActive).ToList(); 
        }

       
    }
}
