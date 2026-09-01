using NexCart.Domain.Common;
using NexCart.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace NexCart.Domain.Entities
{
    public class User : BaseEntity
    {
        public string PhoneNumber { get; set; } = null!;
        public UserRoles Role { get; set; } = UserRoles.Customer;

        public Guid CartId { get; set; }
        public Cart? Cart { get; set; }

        public ICollection<Order> Orders { get; set; } = new HashSet<Order>();
    }
}
