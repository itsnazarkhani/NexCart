using NexCart.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NexCart.Domain.Entities
{
    public class OrderItem : BaseEntity
    {
        public decimal PurchasedPrice{ get; set; }

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        public Guid OrderId { get; set; }
        public Order Order { get; set; } = null!;
    }
}
