
using MicroServicesRabbitMQ.Domain.Commands;
using MicroServicesRabbitMQ.Domain.Events;

namespace MicroServicesRabbitMQ.Domain.Bus
{
    public interface IEventBus
    {
        Task SendCommand<T>(T command) where T : Command;

        void Publish<T>(T @event) where T : Event;

        void Subscribe<T, TH>()
            where T : Event
            where TH : IEventHandler<T>;
    }
}
