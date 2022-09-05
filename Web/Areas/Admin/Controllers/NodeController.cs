using AutoMapper;
using Business.Abstracts;
using Common.Models.ViewModels.Nodes;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NodeController : Controller
    {
        private readonly INodeService _nodeService;
        private readonly IMapper _mapper;

        public NodeController(INodeService nodeService, IMapper mapper)
        {
            _nodeService = nodeService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create(NodeCreateViewModel vm)
        {
            if (ModelState.IsValid)
            {
                var createNodeResponse = await _nodeService.AddAsync(vm);

                if (createNodeResponse.IsSuccess)
                {
                    return RedirectToAction("Index", "Home");
                }
                return BadRequest(createNodeResponse.Message);
            }
            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> ActiveNodes()
        {
            var getNodesResponse = await _nodeService.GetAllAsync();

            if (getNodesResponse.IsSuccess)
            {
                var nodesList = _mapper.Map<List<NodeListViewModel>>(getNodesResponse.Data);
                return View(nodesList.Where(x => x.EndDate > DateTime.Now && x.StartDate < DateTime.Now).ToList());
            }

            return NotFound(getNodesResponse.Message);
        }

        [HttpGet]
        public async Task<IActionResult> DoneNodes()
        {
            var getNodesResponse = await _nodeService.GetAllAsync();

            if (getNodesResponse.IsSuccess)
            {
                var nodesList = _mapper.Map<List<NodeListViewModel>>(getNodesResponse.Data);
                return View(nodesList.Where(x => x.EndDate < DateTime.Now).ToList());
            }

            return NotFound(getNodesResponse.Message);
        }

        [HttpGet]
        public async Task<IActionResult> IncomingNodes()
        {
            var getNodesResponse = await _nodeService.GetAllAsync();

            if (getNodesResponse.IsSuccess)
            {
                var nodesList = _mapper.Map<List<NodeListViewModel>>(getNodesResponse.Data);
                return View(nodesList.Where(x => x.StartDate > DateTime.Now).ToList());
            }

            return NotFound(getNodesResponse.Message);
        }

        [HttpGet]
        public async Task<IActionResult> NodeDetails(string id)
        {
            var getNodeDetailsResponse = await _nodeService.GetById(new Guid(id));
            if (getNodeDetailsResponse.IsSuccess)
            {
                return View(getNodeDetailsResponse.Data);
            }

            return NotFound();
        }
    }
}
