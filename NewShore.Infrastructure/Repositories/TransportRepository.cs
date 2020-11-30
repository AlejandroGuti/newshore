using AutoMapper;
using Microsoft.EntityFrameworkCore;
using NewShore.Common.DTOs;
using NewShore.Infrastructure.Contexts;
using NewShore.Infrastructure.Entities;
using NewShore.Infrastructure.Repositories.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewShore.Infrastructure.Repositories
{
    public class TransportRepository : ITransportRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;

        public TransportRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ICollection<TransportListDTO>> FindAll()
        {
            List<Transport> data = await _context.Transports.ToListAsync();
            return _mapper.Map<ICollection<TransportListDTO>>(data);
        }
        public async Task<TransportListDTO> FindById(int Id)
        {
            Transport data = await _context.Transports.FindAsync(Id);
            return _mapper.Map<TransportListDTO>(data);
        }
        public async Task<TransportListDTO> FligthNumberSearch(string FlightNumber)
        {
            var data = await _context.Transports.Where(o => o.FlightNumber == FlightNumber)
                                     .FirstOrDefaultAsync();

            return _mapper.Map<TransportListDTO>(data);
        }
        public async Task<int> Create(TransportDTO data)
        {
            Transport transport = _mapper.Map<Transport>(data);
            _context.Transports.Add(transport);
            int resp = await _context.SaveChangesAsync();
            return resp;
        }

    }
}
