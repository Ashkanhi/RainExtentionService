using Microsoft.AspNetCore.Mvc;
using RainExtention.Application.Service;
using RainExtention.Domain.Entities;

namespace RainExtentionService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CustomerController : ControllerBase
    {
        private readonly CustomerService _customerService;

        public CustomerController(CustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("GetCustomerByCode")]
        public async Task<IActionResult> GetCustomerByCode([FromBody] GetCustomerRequest request)
        {
            if (string.IsNullOrWhiteSpace(request?.CustomerCode))
                return BadRequest(new { Message = "کد مشتری الزامی است." });

            var customer = await _customerService.CheckCustomerByCodeIdAsync(request.CustomerCode);

            if (customer == null)
                return NotFound(new { Message = "مشتری با این کد وجود ندارد." });

            return Ok(customer);
        }
    }
}