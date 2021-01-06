using System;
using CSharp.Entity;

namespace CSharp.Entity {
    public class Order 
    {
        public Guid Id { get; set; }
        public Guid CustomerId { get; set; }
        public bool Canceled { get; set; }
        public string OrderObject { get; set; }
        public int Amount { get; set; }
    }
}