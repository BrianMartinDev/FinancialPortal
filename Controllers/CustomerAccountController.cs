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
    public class CustomerAccountController : ControllerBase
    {

        private readonly IRepository _repository;

        public CustomerAccountController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<DataController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CustomerAccount>>> CustomerAccountList()
        {
            return await _repository.SelectAll<CustomerAccount>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<CustomerAccount>> GetCustomerAccount(long id)
        {
            var model = await _repository.SelectById<CustomerAccount>(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomerAccount(long id, CustomerAccount model)
        {
            if (id != model.CustomerAccountID)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync<CustomerAccount>(model);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<CustomerAccount>> InsertCustomerAccount([FromBody] CustomerAccount model)
        {
            await _repository.CreateAsync<CustomerAccount>(model);
            return CreatedAtAction("GetCustomerAccount", new { id = model.CustomerAccountID }, model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<CustomerAccount>> DeleteCustomerAccount(long id)
        {
            var model = await _repository.SelectById<CustomerAccount>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<CustomerAccount>(model);

            return model;
        }

    }
}
