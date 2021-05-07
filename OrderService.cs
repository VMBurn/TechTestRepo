using AnyCompany.Repositories.Handler;
using AnyCompany.Repositories.Interfaces;

namespace AnyCompany
{
    public class OrderService : IOrderService
    {
        private readonly OrderRepository orderRepository = new OrderRepository();

        public bool PlaceOrder(Order order, int customerId)
        {
            Customer customer = CustomerRepository.Load(customerId);

            if (order.Amount == 0)
                return false;

            if (customer.Country == "UK")
                order.VAT = Vat.UK; 
            else
                order.VAT = Vat.DEFAULT_VAT;

            orderRepository.Save(order);
            return true;
        }
    }
}
