using NexCart.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NexCart.Domain.Entities
{
    public class CartItem : BaseEntity
    {
        public Guid CartId { get; set; }
        public Cart Cart { get; set; } = null!;

        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;
    }
}
