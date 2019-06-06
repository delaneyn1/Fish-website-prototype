using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCoreWebApp.Models.DataModels;
//Used for customers to submit work orders
namespace MyCoreWebApp.Controllers
{
    public class ServiceRequestController : Controller
    {
        //TODO: create form post of the create method to capture user input. 
        [HttpGet]
        public IActionResult Create()
        {
            //Instantiate model to generate request list
            var model = new ServiceRequestDataModel();        
            
            //view name, object model
            return View("Create",model);
        }
    }
}