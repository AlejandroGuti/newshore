using NewShore.Common.DTOs;
using NewShore.Common.Responses;
using System.Threading.Tasks;

namespace NewShore.Domain.Services.Interfaces
{
    public interface ICustomerService
    {
        Task<Response> Create(FlightDTO model);
    }
}
