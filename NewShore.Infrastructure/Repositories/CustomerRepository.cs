using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using NewShore.Common.DTOs;
using NewShore.Infrastructure.Contexts;
using NewShore.Infrastructure.Entities;
using NewShore.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.Infrastructure.Repositories.Interface
{
    public class CustomerRepository :ICustomerRepository
    {
        private readonly IMapper _mapper;
        private readonly DataContext _context;
        private readonly UserManager<User> _userManager;
        private readonly ITransportRepository _transportRepository;

        public CustomerRepository(
            IMapper mapper,
            DataContext context,
            UserManager<User> userManager,
            ITransportRepository transportRepository )
        {
            _mapper = mapper;
            _context = context;
            _userManager = userManager;
            _transportRepository = transportRepository;
        }
        private async Task<User> FindUser(string email)
        {          
            return await _userManager.FindByEmailAsync(email);
        }

        public async Task<int> Create(FlightDTO data)
        {


            Flight flight = _mapper.Map<Flight>(data);

            flight.Transport = await _context.Transports.Where(t => t.FlightNumber == data.FlightNumber)
                                                        .FirstOrDefaultAsync();
            if (flight.Transport == null)
            {
                flight.Transport = new Transport
                {
                    FlightNumber = data.FlightNumber
                };
            }
                User user = await FindUser(data.UserEmail);

            if (user == null) { return 0; }
            flight.User = user;


            _context.Flights.Add(flight);
            int resp = await _context.SaveChangesAsync();
            return resp;
        }
    }
}
