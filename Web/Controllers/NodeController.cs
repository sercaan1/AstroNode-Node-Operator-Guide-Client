using Business.Abstracts;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class NodeController : Controller
    {
        private readonly INodeService _nodeService;

        public NodeController(INodeService nodeService)
        {
            _nodeService = nodeService;
        }
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
