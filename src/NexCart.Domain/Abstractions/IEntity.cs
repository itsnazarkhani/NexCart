using System;
using System.Collections.Generic;
using System.Text;

namespace NexCart.Domain.Abstractions
{
    public interface IEntity<TId>
    {
        TId Id { get; }
    }
}
