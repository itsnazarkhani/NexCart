using NexCart.Domain.Common;
using NexCart.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NexCart.Domain.Entities
{
    public class Order : BaseEntity
    {
        public decimal TotalPurchasedPrice { get; set; }
        public int NumberOfItems { get; set; }
        public OrderStatus OrderStatus { get; set; }

        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();
    }
}
