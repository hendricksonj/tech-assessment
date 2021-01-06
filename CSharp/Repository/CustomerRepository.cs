using System;
using System.Collections.Generic;
using CSharp.Entity;

namespace CSharp.Repository {  
    public class CustomerRepository {
        public List<Customer> customers = new List<Customer>()
        {
            new Customer() { Id = Guid.Parse("c9820ad9-22d9-4ab8-b291-6a8722656ebb"), Name = "Customer 1"},
            new Customer() { Id = Guid.Parse("50fbb544-3e37-480b-ae86-6661f435d398"), Name = "Customer 2"},
            new Customer() { Id = Guid.Parse("2e2cf47c-adfe-447d-926a-b1e38da72786"), Name = "Customer 3"}
        };        
    }  
}
