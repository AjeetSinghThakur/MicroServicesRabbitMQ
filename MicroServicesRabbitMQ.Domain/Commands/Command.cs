
using MicroServicesRabbitMQ.Domain.Events;

namespace MicroServicesRabbitMQ.Domain.Commands
{
    public abstract class Command : Message
    {
        public DateTime Timestamp { get; protected set; }

        protected Command()
        {
            Timestamp = DateTime.Now;
        }
    }
}
