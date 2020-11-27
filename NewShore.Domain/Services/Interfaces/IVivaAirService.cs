using NewShore.Common.Requests;
using NewShore.Common.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.Domain.Services.Interfaces
{
    public interface IVivaAirService
    {
        Task<Response> SerchFlights(FlightsInfoRequest requestModel);
    }
}
