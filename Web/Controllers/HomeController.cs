using Business.Abstracts;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Serialization;
using System.Diagnostics;
using System.Text.Json;
using Web.Models;

namespace Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly INodeService _nodeService;

        public HomeController(INodeService nodeService)
        {
            _nodeService = nodeService;
        }

        public async Task<IActionResult> Index()
        {
            return View();
        }

        public async Task<IActionResult> FilterNode(string selection)
        {
            var getAllNodesResponse = await _nodeService.GetAllAsync();
            if (getAllNodesResponse.IsSuccess)
            {
                if (selection == "active")
                {
                    var activeNodesList = getAllNodesResponse.Data.Where(x => x.StartDate < DateTime.Now && x.EndDate > DateTime.Now).ToList();
                    return PartialView("_FilterNode", activeNodesList);
                }
                else if (selection == "done")
                {
                    var doneNodesList = getAllNodesResponse.Data.Where(x => x.EndDate < DateTime.Now).ToList();
                    return PartialView("_FilterNode", doneNodesList);
                }
                else
                {
                    var upcomingNodesList = getAllNodesResponse.Data.Where(x => x.StartDate > DateTime.Now).ToList();
                    return PartialView("_FilterNode", upcomingNodesList);
                }
            }

            return NotFound();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}