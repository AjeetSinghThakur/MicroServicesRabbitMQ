using Banking.Domain.Models;

namespace Banking.Domain.Interfaces
{
    public interface IAccountRepository
    {
        Task<IEnumerable<Account>> GetAccounts();
    }
}
