using AutoMapper;
using Business.Abstracts;
using Common.Models.Integration.Users;
using Common.Models.ViewModels.Users;
using Common.Utilities.Abstracts;
using Common.Utilities.Concrete;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class UserManager : BaseManager, IUserService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserManager(IHttpClientFactory httpClientFactory, IMapper mapper, IHttpContextAccessor httpContextAccessor) : base(httpClientFactory, mapper)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<AuthResult> LoginAsync(LoginViewModel requestModel)
        {
            var postLoginRequestModel = _mapper.Map<PostLoginRequestModel>(requestModel);

            var jsonContent = JsonSerializer.Serialize(postLoginRequestModel);

            var requestContent = new HttpRequestMessage(HttpMethod.Post, "Authenticate/Login");
            requestContent.Content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

            var response = await httpClient.SendAsync(requestContent);

            if (response.IsSuccessStatusCode)
            {
                var responseContent = await response.Content.ReadAsStringAsync();
                return new AuthResult(){
                    IsSuccess = true,
                    Token = responseContent
                };
            }

            return new AuthResult() { IsSuccess = false };
        }
    }
}
