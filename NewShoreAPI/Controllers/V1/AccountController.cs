using Microsoft.AspNetCore.Mvc;
using NewShore.Common.Requests;
using NewShore.Domain.Services.Interfaces;
using System;
using System.Threading.Tasks;

namespace NewShoreAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(
             IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("Create")]
        public async Task<ActionResult<UserToken>> CreateUser([FromBody] UserRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return Ok(await _accountService.CreateUser(request));

            }
            catch (Exception ex)
            {

                return BadRequest(ex);
            }

        }

        [HttpPost("Login")]
        public async Task<ActionResult<UserToken>> Login([FromBody] TokenRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                return Ok(await _accountService.Login(request));

            }
            catch (Exception)
            {

                return BadRequest();
            }
        }

    }
}
