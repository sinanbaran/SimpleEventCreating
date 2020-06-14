using System;
using BasicEventSourceModel.Domain.Core;

namespace BasicEventSourceModel.Domain.Products.Events
{
    public class AddedCommentEvent : IEvent
    {

        public Guid Id { get; set; }
        public string Content { get; set; }
        public string UserName { get; set; }
        public Guid AggregateId { get; set; }
    }
}
