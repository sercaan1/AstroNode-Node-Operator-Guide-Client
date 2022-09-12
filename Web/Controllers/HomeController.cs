using AutoMapper;
using Business.Abstracts;
using Common.Models.ViewModels.Users;
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
        private readonly IUserService _userService;

        public HomeController(INodeService nodeService, IUserService userService)
        {
            _nodeService = nodeService;
            _userService = userService;
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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(LoginViewModel model)
        {
            if (ModelState.IsValid)
            {
                var loginResult = await _userService.LoginAsync(model);

                if (loginResult.IsSuccess)
                {
                    HttpContext.Session.SetString("token", loginResult.Token);
                    return RedirectToAction("Index", "Home", new { area = "Admin" });
                }

                return View(model);
            }
            return View(model);
        }
    }
}