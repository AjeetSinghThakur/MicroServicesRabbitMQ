
using Transfer.Domain.Models;

namespace Banking.Domain.Interfaces
{
    public interface ITransferRepository
    {
        Task<IEnumerable<TransferLog>> GetTransferLogs();
    }
}
