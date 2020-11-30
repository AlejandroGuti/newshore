using AutoMapper;
using NewShore.Common.DTOs;
using NewShore.Common.Enums;
using NewShore.Common.Responses;
using NewShore.Domain.Services.Interfaces;
using NewShore.Infrastructure.Repositories.Interface;
using NewShore.Infrastructure.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.Domain.Services
{
    public class CustomerService: ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;
        private readonly ITransportRepository _transportRepository;
        private readonly IMapper _mapper;

        public CustomerService(ICustomerRepository customerRepository, ITransportRepository transportRepository, IMapper mapper)
        {
            _customerRepository = customerRepository;
            _transportRepository = transportRepository;
            _mapper = mapper;
        }
        public async Task<Response> Create(FlightDTO model)
        {

            int result = await _customerRepository.Create(model);

            if (result >= 1)
            {
                return new Response
                {
                    IsSuccess = true,
                    Message = GeneralMessages.Created.ToString(),
                    Result = result
                };
            }
            else
            {
                return new Response
                {
                    IsSuccess = false,
                    Message = GeneralMessages.NotCreated.ToString()
                };
            }
        }

    }
}
