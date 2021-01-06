using System;
using CSharp.Entity;
using System.Collections.Generic;
using CSharp.Repository;
using CSharp.Dto;
using System.Linq;

namespace CSharp.Service 
{
    public class OrderService 
    {
        OrderRepository _orderRepository = new OrderRepository();
        public Guid PostOrder(OrderPostDto newOrderDto) {
            Order newOrder = new Order() { 
                Id = Guid.NewGuid(), 
                CustomerId = newOrderDto.CustomerId,
                Canceled = newOrderDto.Canceled,
                OrderObject = newOrderDto.OrderObject,
                Amount = newOrderDto.Amount
            };
            _orderRepository.orders.Add(newOrder);

            return newOrder.Id;
        }

        public Guid PutOrder(Order updateOrder) {
            var record = _orderRepository.orders.Where(x => x.Id == updateOrder.Id).FirstOrDefault();

            record.Canceled = updateOrder.Canceled;
            record.Amount = updateOrder.Amount;
            record.OrderObject = updateOrder.OrderObject;
            record.CustomerId = updateOrder.CustomerId;

            return record.Id;
        }

        public Guid CancelOrder(Guid orderId) {
            var record = _orderRepository.orders.Where(x => x.Id == orderId).FirstOrDefault();
            record.Canceled = true;
            return record.Id;
        }

        public List<Order> GetOrdersByCustomer(Guid customerId) {
            var records = _orderRepository.orders.Where(x => x.CustomerId == customerId).ToList();
            return records;
        } 

        public List<Order> GetOrders() {
            return _orderRepository.orders;
        } 

        public Order GetOrder(Guid orderId) {
            return _orderRepository.orders.Where(x => x.Id == orderId).FirstOrDefault();
        } 
    }
}