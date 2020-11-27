using Microsoft.AspNetCore.Mvc;
using NewShore.Common.Requests;
using NewShore.Common.Responses;
using NewShore.Domain.Services.Interfaces;
using System;
using System.Threading.Tasks;


namespace NewShoreAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]

    public class VivaAirController : ControllerBase
    {
        private readonly IVivaAirService _vivaAirService;

        public VivaAirController(IVivaAirService vivaAirService)
        {
            _vivaAirService = vivaAirService;
        }

        [HttpPost("SearchInfo")]
        public async Task<ActionResult> SearchInfo([FromBody] FlightsInfoRequest requestModel) //
        {

            try
            {
                if (!ModelState.IsValid)
                {
                    return BadRequest(ModelState);
                }
                Response Info = await _vivaAirService.SerchFlights(requestModel);
                return Ok(Info);
            }
            catch (Exception)
            {

                return BadRequest();
            }

        }
    }
}
