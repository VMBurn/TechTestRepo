using AnyCompany.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.Repositories.Handler
{
    public class CustomerRepositoryHandler : ICustomerRepository
    {
        public CustomerRepositoryHandler() { }

        public Customer Load(int customerId)
        {
            return CustomerRepository.Load(customerId);
        }

    }
}
