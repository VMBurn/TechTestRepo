using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnyCompany.Repositories.Interfaces
{
    public interface ICustomerRepository
    {
         Customer Load(int customerId);
    }
}
