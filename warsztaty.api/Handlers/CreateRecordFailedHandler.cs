using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using warsztaty.messages.Events;

namespace warsztaty.API.Handlers
{
    public class CreateRecordFailedHandler : IEventHandler<CreateRecordFailed>
    {
        public async Task HandleAsync(CreateRecordFailed @event)
        {
            Console.WriteLine($"Record: '{@event.Key}' was NOT created. Reason: '{@event.Reason}'");
            await Task.CompletedTask;
        }
    }
}
