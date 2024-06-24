using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Services.Implementations;
using WebApplication1.Services.Interfaces;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public IActionResult Index()
        {
            GetMessage();
            GetGroups();
            return View();
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



        private readonly IMessageService _messageService;
        private readonly IGroupService _groupService;
        ChatModel ChatModel = new ChatModel();
        public HomeController(IMessageService messageService,IGroupService groupService)
        {
            _messageService = messageService;
            _groupService = groupService;
        }
        
        [HttpGet]
        public async Task<IActionResult> GetMessage()
        {
            var response = _messageService.GetAll();
            if (response.Result.StatusCode == Models.Enum.StatusCode.OK)
            {
                ChatModel.messages = response.Result.Data.ToList();
                return View(ChatModel);
            }
            return View("Index");
        }

        [HttpPost]
        public async Task<IActionResult> SendMessage(string message,int id_group)
        {
            string id_user = GetUserLoginFromCookie(Request);
            var response = await _messageService.Create(message, id_user,id_group);
            if (response.StatusCode == Models.Enum.StatusCode.OK)
            {
                GetMessage();
            }
            return View("Index");
        }
        [HttpGet]
        public async Task<IActionResult> GetGroups()
        {
            var response = await _groupService.GetAll();
            if(response.StatusCode == Models.Enum.StatusCode.OK)
            {
                ChatModel.groups = response.Data.ToList();
                return View(ChatModel);
            }
            return View("Index");
        }
        public string GetUserLoginFromCookie(HttpRequest request)
        {
            var claimIdentity = request.HttpContext.User.Identity.Name;
            if (claimIdentity != null)
            {
                var loginClaim = claimIdentity;
                if (loginClaim != null)
                {
                    return loginClaim;
                }
            }
            return null;
        }
    }
}
