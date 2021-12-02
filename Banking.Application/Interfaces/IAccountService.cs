
using Banking.Application.Models;
using Banking.Domain.Models;

namespace Banking.Application.Interfaces
{
    public interface IAccountService
    {
        Task<IEnumerable<Account>> GetAccounts();
        Task Transfer(AccountTransfer accountTransfer);
    }
}
