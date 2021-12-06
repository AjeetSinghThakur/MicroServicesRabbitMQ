using Banking.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Transfer.Data.Context;
using Transfer.Domain.Models;

namespace Banking.Data.Repository
{
    public class TransferRepository : ITransferRepository
    {
        private readonly TransferDbContext _transferDbContext;
        public TransferRepository(TransferDbContext transferDbContext)
        {
            _transferDbContext = transferDbContext;
        }

        public async Task<IEnumerable<TransferLog>> GetTransferLogs()
        {
            return await _transferDbContext.TransferLogs.ToListAsync();
        }
    }
}
