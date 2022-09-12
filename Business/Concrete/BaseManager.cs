using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class BaseManager
    {
        public readonly IHttpClientFactory _httpClientFactory;
        public readonly IMapper _mapper;
        public JsonSerializerOptions options;
        public HttpClient httpClient;

        public BaseManager(IHttpClientFactory httpClientFactory, IMapper mapper)
        {
            _httpClientFactory = httpClientFactory;
            _mapper = mapper;
            httpClient = httpClientFactory.CreateClient("ReplicaAPI");
            options = new JsonSerializerOptions
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase
            };
        }
    }
}
