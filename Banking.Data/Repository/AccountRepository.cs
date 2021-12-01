using Banking.Data.Context;
using Banking.Domain.Interfaces;
using Banking.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace Banking.Data.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly BankingDbContext _bankingDbContext;
        public AccountRepository(BankingDbContext bankingDbContext)
        {
            _bankingDbContext = bankingDbContext;
        }
        public async Task<IEnumerable<Account>> GetAccounts()
        {
            return await _bankingDbContext.Accounts.ToListAsync();
        }
    }
}
