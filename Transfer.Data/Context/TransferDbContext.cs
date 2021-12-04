
using Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Transfer.Data.Context
{
    public class TransferDbContext: DbContext
    {
        public TransferDbContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<TransferLog> TransferLog { get; set; }
    }
}
 