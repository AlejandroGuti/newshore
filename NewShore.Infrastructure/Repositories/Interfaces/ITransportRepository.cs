using NewShore.Common.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.Infrastructure.Repositories.Interfaces
{
    public interface ITransportRepository
    {
        Task<int> Create(TransportDTO data);
        Task<TransportListDTO> FligthNumberSearch(string FlightNumber);
        Task<TransportListDTO> FindById(int Id);
        Task<ICollection<TransportListDTO>> FindAll();
    }
}
