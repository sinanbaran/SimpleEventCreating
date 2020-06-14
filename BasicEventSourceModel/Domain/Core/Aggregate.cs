using System.Collections.Generic;
using ReflectionMagic;

namespace BasicEventSourceModel.Domain.Core
{
    public class Aggregate
    {

        public IList<IEvent> @Events { get; set; } = new List<IEvent>();

        public void ApplyEvents(IList<IEvent> events)
        {
            foreach (var @event in events)
            {
                this.AsDynamic().BuildEvent(@event);
            }
        }
    }
}