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
    public class CustomerController : ControllerBase
    {

        private readonly IRepository _repository;

        public CustomerController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<DataController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Customer>>> CustomerList()
        {
            return await _repository.SelectAll<Customer>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(long id)
        {
            var model = await _repository.SelectById<Customer>(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCustomer(long id, Customer model)
        {
            if (id != model.CustomerId)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync<Customer>(model);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Customer>> InsertCustomer([FromBody] Customer model)
        {
            await _repository.CreateAsync<Customer>(model);
            return CreatedAtAction("GetCustomer", new { id = model.CustomerId }, model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Customer>> DeleteCustomer(long id)
        {
            var model = await _repository.SelectById<Customer>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<Customer>(model);

            return model;
        }

    }

}
