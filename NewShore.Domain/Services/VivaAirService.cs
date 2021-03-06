﻿using NewShore.Common.Enums;
using NewShore.Common.Requests;
using NewShore.Common.Responses;
using NewShore.Domain.Services.Interfaces;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace NewShore.Domain.Services
{
    public class VivaAirService : IVivaAirService
    {
        public async Task<Response> SerchFlights(FlightsInfoRequest requestModel)
        {
            try
            {
                if (requestModel.From <= DateTime.Now)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = PostDestination.ErrorDate.ToString()
                    };
                }
                string urlBase = "http://testapi.vivaair.com";
                string prefix = "/otatest/api";
                string controller = "/values";
                HttpClient client = new HttpClient
                {
                    BaseAddress = new Uri(urlBase)
                };
                string url = $"{prefix}{controller}";
                string request = JsonConvert.SerializeObject(requestModel);
                StringContent content = new StringContent(request, Encoding.UTF8, "application/json");

                HttpResponseMessage response = await client.PostAsync(url, content);
                string answer = await response.Content.ReadAsStringAsync();
                if (!response.IsSuccessStatusCode)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = GeneralMessages.FailedConmunication.ToString()
                    };
                }
                object flightsInfoResponses = JsonConvert.DeserializeObject(answer);
                ICollection<FlightsInfoResponse> flightsInfoResponses1 =
                    JsonConvert.DeserializeObject<ICollection<FlightsInfoResponse>>(flightsInfoResponses.ToString());
                if (flightsInfoResponses1 == null)
                {
                    return new Response
                    {
                        IsSuccess = false,
                        Message = GeneralMessages.NotFound.ToString()
                    };
                }

                return new Response
                {
                    IsSuccess = true,
                    Message = GeneralMessages.Found.ToString(),
                    Result = flightsInfoResponses1
                };
            }
            catch (Exception ex)
            {
                return new Response
                {
                    Message = ex.ToString(),
                    IsSuccess = false,
                };
            }

        }

    }

}
