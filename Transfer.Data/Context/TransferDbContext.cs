
using Transfer.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Transfer.Data.Context
{
    public class TransferDbContext: DbContext
    {
        public TransferDbContext(DbContextOptions options): base(options)
        {
        }
        public DbSet<TransferLog> TransferLogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.RemovePluralizingTableNameConvention();
        }
    }
}
 