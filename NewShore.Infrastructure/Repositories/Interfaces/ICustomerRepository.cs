using NewShore.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.Infrastructure.Repositories.Interface
{
    public interface ICustomerRepository
    {
        Task<int> Create(FlightDTO data);
    }
}
