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
    public class AddressController : ControllerBase
    {

        private readonly IRepository _repository;

        public AddressController(IRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<DataController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Address>>> AddressList()
        {
            return await _repository.SelectAll<Address>();
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Address>> GetAddress(long id)
        {
            var model = await _repository.SelectById<Address>(id);

            if (model == null)
            {
                return NotFound();
            }

            return model;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateAddress(long id, Address model)
        {
            if (id != model.AddressID)
            {
                return BadRequest();
            }

            await _repository.UpdateAsync<Address>(model);

            return NoContent();
        }

        [HttpPost]
        public async Task<ActionResult<Address>> InsertAddress([FromBody] Address model)
        {
            await _repository.CreateAsync<Address>(model);
            return CreatedAtAction("GetAddress", new { id = model.AddressID }, model);
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Address>> DeleteAddress(long id)
        {
            var model = await _repository.SelectById<Address>(id);

            if (model == null)
            {
                return NotFound();
            }

            await _repository.DeleteAsync<Address>(model);

            return model;
        }

    }
}
