using NexCart.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace NexCart.Domain.Entities
{
    public class Cart : BaseEntity
    {
        public Guid UserId { get; set; }
        public User User { get; set; } = null!;

        public ICollection<CartItem> CartItems { get; set; } = new HashSet<CartItem>();
    }
}
