using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomersController(ICustomerService customerService)
        {
            _customerService = customerService;
        }
        
        [HttpPost("Add")]
        public IActionResult Add(Customer customer)
        {
            var result = _customerService.Add(customer);
            
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        
        [HttpPut("Update")]
        public IActionResult Update(Customer customer)
        {
            var result = _customerService.Update(customer);
            
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        
        [HttpDelete("Delete")]
        public IActionResult Delete(Customer customer)
        {
            var result = _customerService.Delete(customer);
            
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        
        
        [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var result = _customerService.GetAll();
            
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        
        [HttpGet("GetById")]
        public IActionResult GetById(int customerId)
        {
            var result = _customerService.GetById(customerId);
            
            if (result.Success)
            {
                return Ok(result);
            }

            return BadRequest(result);
        }
        
    }
}
