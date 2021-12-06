using Transfer.Application.Interfaces;
using Transfer.Domain.Models;
using MicroServicesRabbitMQ.Domain.Bus;
using Banking.Domain.Interfaces;

namespace Banking.Application.Services
{
    public class TransferService : ITransferService
    {
        private readonly ITransferRepository _transferRepository;
        private readonly IEventBus _bus;

        public TransferService(ITransferRepository transferRepository, IEventBus bus)
        {
            _transferRepository = transferRepository;
            _bus = bus;
        }
        public async Task<IEnumerable<TransferLog>> GetTransferLogs()
        {
            return await _transferRepository.GetTransferLogs().ConfigureAwait(false);
        }
    }
}
