using Microsoft.AspNetCore.Mvc;
using System;
using TreatApplication.Services;
using TreatApplication.ViewModels;

namespace TreatApplication.Controllers
{
    public class AppController : Controller
    { 
        private readonly IMailService _mailService;

        public AppController(IMailService mailService)
        {
            _mailService = mailService;
        }

        public IActionResult Index()
        {
            
            return View();
        }
        [HttpGet("Contact")]
        public IActionResult Contact()
        {
  
            return View();
        }

        [HttpPost("Contact")]
        public IActionResult Contact(ContactViewModel model)
        {
            if (ModelState.IsValid)
            {
                _mailService.SendMessage("mirzamujtaba@gmail.com", model.Subject, $"From: {model.Name} - {model.Email}, Message: {model.Message}");
                ViewBag.UserMessage = "Mail sent";
                ModelState.Clear();
            }
            else
            {

            }
            return View();

        }

        public IActionResult About()
        {
            ViewBag.Title = "About Us";
            return View();
        }
    }
}
