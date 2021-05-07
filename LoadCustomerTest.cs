using AnyCompany.Repositories.Handler;
using AnyCompany.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AnyCompany.Test
{
    [TestClass]
    public class LoadCustomerTest
    {
        ICustomerRepository customerRepo;
        Customer customer;
        public LoadCustomerTest()
        {
            customerRepo = new CustomerRepositoryHandler();
            customer = new Customer();
        }

        [TestMethod]
        public void Load_Customer_Test()
        {
            var customerId = 1;
            customer = customerRepo.Load(customerId);

            Assert.IsTrue(customer != null, "Customer not loaded");
        }

    }
}
