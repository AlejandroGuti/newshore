using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using NewShore.Common.DTOs;
using NewShore.Common.Responses;
using NewShore.Domain.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace NewShoreAPI.Controllers.V1
{
    [Route("api/v1/[controller]")]
    [ApiController]
    [EnableCors("CorsAPIAngular")]
    [Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme, Roles = "Admin")]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpPost("Create")]
        public async Task<ActionResult> Create([FromBody] FlightDTO request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }


                return Ok(await _customerService.Create(request));

            }
            catch (Exception ex)
            {

                return BadRequest(new Response
                {
                    IsSuccess = true,
                    Message = ex.Message
                });
            }

        }
    }
}
