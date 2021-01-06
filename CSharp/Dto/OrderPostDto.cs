using System;
using CSharp.Entity;

namespace CSharp.Dto {
    public class OrderPostDto 
    {
        public Guid CustomerId { get; set; }
        public bool Canceled { get; set; }
        public string OrderObject { get; set; }
        public int Amount { get; set; }
    }
}