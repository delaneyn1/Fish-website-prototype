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

            //Getting todays current date
            DateTime CurrentTime = DateTime.Now;
            
            model.IdealRequestDate = CurrentTime.AddDays(3);

            //view name, object model
            return View("Create",model);
        }

        public IActionResult Create2(string ServiceRequestDescription, int RequestTypeId, string RequestName, string Email, bool CustomerConsent)
        {
            //Instantiate model to generate request list
            var model = new ServiceRequestDataModel();

            model.ServiceRequestDescription = ServiceRequestDescription;
            model.Email = Email;
            model.CustomerConsent = CustomerConsent;
            model.RequestTypeInformation.Select(x => x.RequestTypeId == RequestTypeId);
            model.RequestTypeInformation.Where(x => x.RequestTypeId == RequestTypeId).Select(x => x.RequestName);

            //Getting todays current date
            DateTime CurrentTime = DateTime.Now;

            model.IdealRequestDate = CurrentTime.AddDays(3);

            //view name, object model
            return View("Create2", model);
        }
    }
}