using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyCoreWebApp.Models;
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

        public IActionResult Create2(string ServiceDescription, int RequestTypeId, string RequestName, string Email, bool CustomerConsent, string RequestType)
        {
            //Instantiate model to generate request list
            var model = new ServiceRequestViewModel();

            model.ServiceDescription = ServiceDescription;
            model.Email = Email;
            model.CheckBox = CustomerConsent;
            model.Id = RequestTypeId;
            model.Name = RequestName;
            model.RequestType = RequestType;


            //1. First get the list of possible request options a customer can select from
           IEnumerable<string> Mylist = GetServiceRequestOptions();

            //2. Bind the list to the model 
            model.RequestTypeDdl = CreateSelectList(Mylist);

            
            return View("Create", model);
        }

        // Add Service Request options here if needed
        private IEnumerable<string> GetServiceRequestOptions()
        {
            return new List<string>
            {
                "General Checkup",
                "Maintenance / Repair",
                "Cleaning",
                "Equipment",
                "Tank Modfication",
                "Other"               
            };
        }


        // This is one of the most important parts in the whole example.
        // This function takes a list of strings and returns a list of SelectListItem objects.
        // These objects are going to be used later in the SignUp.html template to render the
        // DropDownList.
        private IEnumerable<SelectListItem> CreateSelectList(IEnumerable<string> elements)
        {
            // Create an empty list to hold result of the operation
            List<SelectListItem> selectList = new List<SelectListItem>();

            // For each string in the 'elements' variable, create a new SelectListItem object
            // that has both its Value and Text properties set to a particular value.
            // This will result in MVC rendering each item as:
            //     <option value="Request Type">Request Type Name</option>
            foreach (var element in elements)
            {
                selectList.Add(new SelectListItem
                {
                    Value = element,
                    Text = element
                });
            }

            return selectList;
        }
    }
}