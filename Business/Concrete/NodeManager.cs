using AutoMapper;
using Business.Abstracts;
using Common.Constants;
using Common.Models.Integration.Nodes;
using Common.Models.ViewModels.Nodes;
using Common.Utilities.Abstracts;
using Common.Utilities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class NodeManager : BaseManager, INodeService
    {
        public NodeManager(IHttpClientFactory httpClientFactory, IMapper mapper) : base(httpClientFactory, mapper)
        {
        }

        public async Task<IDataResult<List<NodeIndexViewModel>>> GetAllAsync()
        {
            var httpResponseMessage = await httpClient.GetAsync("Node/AllNodes");

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

                var getNodeResponseModels = await JsonSerializer.DeserializeAsync<List<GetNodeListResponseModel>>(contentStream, options);

                return new SuccessDataResult<List<NodeIndexViewModel>>(_mapper.Map<List<NodeIndexViewModel>>(getNodeResponseModels), Messages.ListedSuccessfully);
            }

            return new ErrorDataResult<List<NodeIndexViewModel>>(Messages.NotFound);
        }

        public async Task<IDataResult<NodeDetailsViewModel>> GetById(Guid id)
        {
            var httpResponseMessage = await httpClient.GetAsync("Node/" + id);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

                var getNodeDetailsResponseModel = await JsonSerializer.DeserializeAsync<GetNodeDetailsReponseModel>(contentStream, options);

                return new SuccessDataResult<NodeDetailsViewModel>(_mapper.Map<NodeDetailsViewModel>(getNodeDetailsResponseModel), Messages.ListedSuccessfully);
            }

            return new ErrorDataResult<NodeDetailsViewModel>(Messages.NotFound);
        }
    }
}
