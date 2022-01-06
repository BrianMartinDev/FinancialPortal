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
    public class AccountController : ControllerBase
    {

        private readonly IRepository _repository;

        public AccountController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<DataController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Account>>> AccountList()
        {
            return await _repository.SelectAll<Account>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Account>> GetAccount(long id)
        {
            var model = await _repository.SelectById<Account>(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAccount(long id, Account model)
        {
            if (id != model.AccountID)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync<Account>(model);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Account>> InsertAccount([FromBody] Account model)
        {
            await _repository.CreateAsync<Account>(model);
            return CreatedAtAction("GetAccount", new { id = model.AccountID }, model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Account>> DeleteAccount(long id)
        {
            var model = await _repository.SelectById<Account>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<Account>(model);

            return model;
        }

    }
}
