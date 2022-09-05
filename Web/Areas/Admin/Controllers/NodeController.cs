using Business.Abstracts;
using Common.Models.ViewModels.Nodes;
using Microsoft.AspNetCore.Mvc;

namespace Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class NodeController : Controller
    {
        private readonly INodeService _nodeService;

        public NodeController(INodeService nodeService)
        {
            _nodeService = nodeService;
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
    }
}
