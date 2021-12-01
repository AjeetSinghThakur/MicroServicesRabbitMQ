
using Banking.Domain.Models;

namespace Banking.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccounts();
    }
}
