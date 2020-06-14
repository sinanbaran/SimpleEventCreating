using System;
using BasicEventSourceModel.Domain.Core;

namespace BasicEventSourceModel.Domain.Products.Events
{
    public class CreatedProductEvent : IEvent
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Guid AggregateId { get; set; }
    }
}