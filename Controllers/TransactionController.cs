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
    public class TransactionController : ControllerBase
    {

        private readonly IRepository _repository;

        public TransactionController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<DataController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Transaction>>> TransactionList()
        {
            return await _repository.SelectAll<Transaction>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Transaction>> GetTransaction(long id)
        {
            var model = await _repository.SelectById<Transaction>(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateTransaction(long id, Transaction model)
        {
            if (id != model.TransactionId)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync<Transaction>(model);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Transaction>> InsertTransaction([FromBody] Transaction model)
        {
            await _repository.CreateAsync<Transaction>(model);
            return CreatedAtAction("GetTransaction", new { id = model.TransactionId }, model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Transaction>> DeleteTransaction(long id)
        {
            var model = await _repository.SelectById<Transaction>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<Transaction>(model);

            return model;
        }

    }
}
