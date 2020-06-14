using System;

namespace BasicEventSourceModel.Domain.Core
{
    public interface IEvent
    {
        Guid AggregateId { get; set; }
    }

}
