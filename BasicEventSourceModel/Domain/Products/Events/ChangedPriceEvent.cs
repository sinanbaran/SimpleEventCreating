using System;
using BasicEventSourceModel.Domain.Core;

namespace BasicEventSourceModel.Domain.Products.Events
{
    public class ChangedPriceEvent : IEvent
    {
        public double Price { get; set; }
        public Guid AggregateId { get; set; }
    }
}
