using System;
using System.Collections.Generic;
using CSharp.Entity;

namespace CSharp.Repository {  
    public class OrderRepository {
        private static List<Order> _orders = new List<Order>()
        {
            new Order() { 
                Id = Guid.Parse("c9820ad9-22d9-4ab8-b291-6a8722656ebb"), 
                CustomerId = Guid.Parse("c9820ad9-22d9-4ab8-b291-6a8722656ebb"),
                Canceled = false,
                OrderObject = "Fan",
                Amount = 1
            },
            new Order() { 
                Id = Guid.Parse("c8de9873-f43d-4f6a-abfc-59e2f760645c"), 
                CustomerId = Guid.Parse("c9820ad9-22d9-4ab8-b291-6a8722656ebb"),
                Canceled = false,
                OrderObject = "Fan",
                Amount = 1
            },
            new Order() { 
                Id = Guid.Parse("4664146d-1722-4346-96af-cb5b9efef995"), 
                 CustomerId = Guid.Parse("c9820ad9-22d9-4ab8-b291-6a8722656ebb"),
                 Canceled = false,
                 OrderObject = "Fan",
                 Amount = 1
            },
            new Order() { 
                Id = Guid.Parse("fb487753-ece7-41e7-a8b0-c4f20bc84411"), 
                 CustomerId = Guid.Parse("50fbb544-3e37-480b-ae86-6661f435d398"),
                 Canceled = false,
                 OrderObject = "Fan",
                 Amount = 1
            }
        };        
        public List<Order> orders 
        {   
            get { return _orders; }    
            set { _orders = value; }
        }
    }  
}