using NexCart.Domain.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace NexCart.Domain.Common
{
    public abstract class BaseEntity : IEntity<Guid>
    {
        public Guid Id { get; protected set; } = Guid.CreateVersion7();
    }
}
