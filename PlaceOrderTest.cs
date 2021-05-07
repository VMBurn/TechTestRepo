using AnyCompany.Repositories.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;
using System.Diagnostics;

namespace AnyCompany.Test
{
    [TestClass]
    public class PlaceOrderTest
    {
        IOrderService mockOrderService;
        Mock<IOrderRepository> mockIOrder;
        Order objOrder;

        public PlaceOrderTest()
        {
            mockOrderService = new OrderService();
            
            objOrder = new Order()
            {
                OrderId = 6,
                CustomerId = 2,
                Amount = 70,
                VAT = 0
            };
        }

        #region Test for Placing an order method

        [TestMethod]
        public void PlaceOrder_Test()
        {
            var customerId = 2;

            var isPlaceOrder = mockOrderService.PlaceOrder(objOrder, customerId);

            Assert.AreEqual(true, isPlaceOrder);
            Assert.IsTrue(isPlaceOrder, "Order was unsuccessful");
        }
        #endregion

        #region Save_Order_Test
        [TestMethod]
        public void Save_Order_Test()
        {
            if (objOrder != null)
            {
                mockIOrder = new Mock<IOrderRepository>();
                mockIOrder.Setup(x => x.Save(objOrder));

            }

            Assert.IsNotNull(objOrder, "Order was unsuccessful");
            Debug.Assert(objOrder != null, "Order object loaded!");

        }
        #endregion

    }



}
