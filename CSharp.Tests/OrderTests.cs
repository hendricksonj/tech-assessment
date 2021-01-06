using System;
using Xunit;
using CSharp.Service;
using CSharp.Dto;
using CSharp.Entity;
using System.Linq;

namespace CSharp.Tests
{
    public class OrderTests
    {
        public OrderService _orderService = new OrderService();

        [Fact]
        public void TestPost()
        {
            //arrange
            var orderPostDto = new OrderPostDto() {
                CustomerId = Guid.Parse("c9820ad9-22d9-4ab8-b291-6a8722656ebb"),
                Canceled = false,
                OrderObject = "book",
                Amount = 3
            };

            var createdId = _orderService.PostOrder(orderPostDto);
            var createdOrder = _orderService.GetOrder(createdId);

            Assert.Equal(orderPostDto.CustomerId, createdOrder.CustomerId);
            Assert.Equal(orderPostDto.Canceled, createdOrder.Canceled);
            Assert.Equal(orderPostDto.OrderObject, createdOrder.OrderObject);
            Assert.Equal(orderPostDto.Amount, createdOrder.Amount);
        }

        [Fact]
        public void TestPut()
        {
            var order = _orderService.GetOrders().FirstOrDefault();
            var orderToSave = new Order() {
                Id = order.Id,
                CustomerId = order.CustomerId,
                Canceled = true,
                OrderObject = "Hat",
                Amount = 0,
            };

            var updatedId = _orderService.PutOrder(orderToSave);
            var updatedOrder = _orderService.GetOrder(updatedId);

            Assert.True(updatedOrder.Canceled);
            Assert.Equal("Hat", updatedOrder.OrderObject);
            Assert.Equal(0, updatedOrder.Amount);
        }

        [Fact]
        public void TestCancel()
        {
            var orderId = _orderService.GetOrders().Where(x => !x.Canceled).FirstOrDefault().Id;

            var cancelledId = _orderService.CancelOrder(orderId);
            var cancelledOrder = _orderService.GetOrder(cancelledId);

            Assert.True(cancelledOrder.Canceled);
        }
    }
}
