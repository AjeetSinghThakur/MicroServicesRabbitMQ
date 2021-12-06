using Microsoft.AspNetCore.Mvc;
using Transfer.Application.Interfaces;
using Transfer.Domain.Models;

namespace Banking.Api.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class TransferController : ControllerBase
    {
        private readonly ITransferService _transferService;

        public TransferController(ITransferService transferService)
        {
            _transferService = transferService;
        }

        [HttpGet(Name = "getTransferLogs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<IEnumerable<TransferLog>>> Get()
        {
            var transferLogs = await _transferService.GetTransferLogs();
            if(transferLogs == null)
            {
                return NotFound();
            }
            return Ok(transferLogs);
        }
    }
}