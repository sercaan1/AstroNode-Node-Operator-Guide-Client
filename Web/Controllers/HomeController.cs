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
            var getAllNodesResponse = await _nodeService.GetAllAsync();
            if (getAllNodesResponse.IsSuccess)
            {
                return View(getAllNodesResponse.Data);
            }
            return View(getAllNodesResponse.Message);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}