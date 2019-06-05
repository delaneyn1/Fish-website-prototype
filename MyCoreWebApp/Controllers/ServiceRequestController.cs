using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
//Used for customers to submit work orders
namespace MyCoreWebApp.Controllers
{
    public class ServiceRequestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}