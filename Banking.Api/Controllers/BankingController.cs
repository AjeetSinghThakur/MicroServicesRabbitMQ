using Banking.Application.Interfaces;
using Banking.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace Banking.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BankingController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public BankingController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpGet(Name = "getAccounts")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<Account>>> Get()
        {
            var accounts = await _accountService.GetAccounts();
            if(accounts == null)
            {
                return NotFound();
            }
            return Ok(accounts);
        }
    }
}