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

        public async Task<IDataResult<List<NodeIndexViewModel>>> GetActiveNodesAsync()
        {
            return await GetAndMapNodes("Node/ActiveNodes");
        }

        public async Task<IDataResult<List<NodeIndexViewModel>>> GetAllAsync()
        {
            return await GetAndMapNodes("Node/AllNodes");
        }

        public Task<IDataResult<GetNodeResponseModel>> GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public async Task<IDataResult<List<NodeIndexViewModel>>> GetDoneNodesAsync()
        {
            return await GetAndMapNodes("Node/DoneNodes");
        }
        private async Task<IDataResult<List<NodeIndexViewModel>>> GetAndMapNodes(string endPoint)
        {
            var httpResponseMessage = await httpClient.GetAsync(endPoint);

            if (httpResponseMessage.IsSuccessStatusCode)
            {
                using var contentStream = await httpResponseMessage.Content.ReadAsStreamAsync();

                var getNodeResponseModels = await JsonSerializer.DeserializeAsync<List<GetNodeResponseModel>>(contentStream, options);

                return new SuccessDataResult<List<NodeIndexViewModel>>(_mapper.Map<List<NodeIndexViewModel>>(getNodeResponseModels), Messages.ListedSuccessfully);
            }

            return new ErrorDataResult<List<NodeIndexViewModel>>(Messages.NotFound);
        }
    }
}
