using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CSharp.Service;
using CSharp.Entity;
using CSharp.Dto;

namespace CSharp.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class OrderController : ControllerBase
	{ 
		private OrderService _orderService = new OrderService();

		[HttpGet]
		[Route("byCustomer/{customerId}")]	//https://localhost:5001/order/bycustomer/c9820ad9-22d9-4ab8-b291-6a8722656ebb
		public List<Order> GetOrderByCustomer(Guid customerId)
		{
			try 
			{
				return _orderService.GetOrdersByCustomer(customerId);
			}
			catch 
			{
				return new List<Order>();
			}
		}

		[HttpGet]
		[Route("{orderId}")]	//https://localhost:5001/order/bycustomer/c9820ad9-22d9-4ab8-b291-6a8722656ebb
		public Order GetOrder(Guid orderId)
		{
			try 
			{
				return _orderService.GetOrder(orderId);
			}
			catch 
			{
				return new Order();
			}
		}

		[HttpPost]
		public string PostOrder([FromBody]OrderPostDto newOrder)
		{
			try 
			{
				var createdId = _orderService.PostOrder(newOrder);
				return $"Order {createdId} successfully created.";
			}
			catch 
			{
				return "Error creating new order.";
			}
		}

		[HttpPut]
		public string PutOrder([FromBody]Order updateOrder)
		{
			try 
			{
				var updatedId = _orderService.PutOrder(updateOrder);
				return $"Order {updatedId} successfully updated.";
			}
			catch 
			{
				return "Error updating order.";
			}
		}

		
		[HttpPut]
		[Route("cancel/{orderId}")]
		//https://localhost:5001/order/cancel/c9820ad9-22d9-4ab8-b291-6a8722656ebb
		public string CancelOrder(Guid orderId)
		{
			try 
			{
				var cancelledId = _orderService.CancelOrder(orderId);
				return $"Order {cancelledId} successfully cancelled.";
			}
			catch 
			{
				return "Error cancelling order.";
			}
		}
	}
}