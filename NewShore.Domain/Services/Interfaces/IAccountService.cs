using NewShore.Common.Requests;
using NewShore.Common.Responses;
using System.Threading.Tasks;

namespace NewShore.Domain.Services.Interfaces
{
    public interface IAccountService
    {
        Task<Response> CreateUser(UserRequest SearchString);
        Task<Response> Login(TokenRequest SearchString);
    }
}
