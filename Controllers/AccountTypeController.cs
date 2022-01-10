using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using FinancialPortal.Models;
using FinancialPortal.Repository;
using Microsoft.AspNetCore.Mvc;

namespace FinancialPortal.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountTypeController : ControllerBase
    {

        private readonly IRepository _repository;

        public AccountTypeController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<DataController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AccountType>>> AccountTypeList()
        {
            return await _repository.SelectAll<AccountType>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<AccountType>> GetAccountType(long id)
        {
            var model = await _repository.SelectById<AccountType>(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAccountType(long id, AccountType model)
        {
            if (id != model.AccountTypeId)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync<AccountType>(model);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<AccountType>> InsertAccountType([FromBody] AccountType model)
        {
            await _repository.CreateAsync<AccountType>(model);
            return CreatedAtAction("GetAccountType", new { id = model.AccountTypeId }, model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<AccountType>> DeleteAccountType(long id)
        {
            var model = await _repository.SelectById<AccountType>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<AccountType>(model);

            return model;
        }

    }
}
