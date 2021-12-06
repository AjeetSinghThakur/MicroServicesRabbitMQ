
using Transfer.Domain.Models;

namespace Transfer.Application.Interfaces
{
    public interface ITransferService
    {
        Task<IEnumerable<TransferLog>> GetTransferLogs();
    }
}
