using Microsoft.AspNetCore.Mvc;
using RainExtention.Infrastructure.Repositories;

namespace RainExtentionService.Controllers
{

        [ApiController]
        [Route("api/[controller]")]
        public class EnableProceduresController : ControllerBase
        {
            private readonly EnableProceduresRepository _service;

            public EnableProceduresController(EnableProceduresRepository service)
            {
                _service = service;
            }

            // POST: api/DisableProcedures/run
            [HttpPost("run")]
            public async Task<IActionResult> RunProcedure()
            {
                try
                {
                    var affectedRows = await _service.RunEnableProcedures();
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
