using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;
using  RainExtention.Infrastructure.Repositories;

namespace RainExtentionService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class DisableProceduresController : ControllerBase
    {
        private readonly DisableProceduresRepository _service;

        public DisableProceduresController(DisableProceduresRepository service)
        {
            _service = service;
        }

        // POST: api/DisableProcedures/run
        [HttpPost("run")]
        public async Task<IActionResult> RunProcedure()
        {
            try
            {
                 var affectedRows = await _service.RunDisableProcedures();
                //var affectedRows = 0;
                return Ok(new
                {
                    Success = true,
                    Message = "Stored Procedure executed successfully.",
                    AffectedRows = affectedRows
                });

            }
            catch (Exception ex)
            {
                return StatusCode(500, new { Success = false, Message = ex.Message });
            }

        }
    }
}
