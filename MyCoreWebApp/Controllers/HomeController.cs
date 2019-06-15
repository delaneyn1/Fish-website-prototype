using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyCoreWebApp.Models;
using Bogus;
using Microsoft.AspNetCore.Mvc.Rendering;
using MyCoreWebApp.Models.DataModels;

//TODO: Models/Views/Controllers needed for Services, Images 

namespace MyCoreWebApp.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Message"] = new Faker().Lorem.Paragraph().ToString();
            var list = GetOurServices();
            var model = new HomeDataModel();
            model.OurServicesList = GetSelectListItems(list);


            model.CardContentList = list;//GetCardContent(list.Count());


            return View(model);
        }

        public IActionResult About()
        {
            ViewData["Message"] = "The services we provide can go here...";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Fish contact page here.";

            return View();
        }
        public IActionResult GettingStarted()
        {
            ViewData["Message"] = "Getting Started";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        // Just return a list of states - in a real-world application this would call
        // into data access layer to retrieve states from a database.
        private IEnumerable<string> GetOurServices()
        {
            return new List<string>
            {
                "Free Estimates",
                "Commercial and Residential",
                "Complete Cleaning and Maintenance",
                "Trouble Shooting",
                "Aquarium Moving",
                "Full Water Test",
                "Aquarium Removal",
                "Complete Installations",
            };
        }

        //Using faker class to build content for card body on the home page.
        private IEnumerable<string> GetCardContent(int numberOfRants)
        {
            int i = 0;
            List<string> contentlist = new List<string>();
            //until we hit 0 keep building content for the card body example
            while (numberOfRants > i)
            {
                //create a new string each loop and replace it to gain more content
                string something = new Faker().Lorem.Sentence();
                contentlist.Add(something);
                //subtract one from rants
                numberOfRants -= 1;
            }
            return contentlist;
        }

        // This is one of the most important parts in the whole example.
        // This function takes a list of strings and returns a list of SelectListItem objects.
        // These objects are going to be used later in the SignUp.html template to render the
        // DropDownList.
        private IEnumerable<SelectListItem> GetSelectListItems(IEnumerable<string> elements)
        {
            // Create an empty list to hold result of the operation
            var selectList = new List<SelectListItem>();

            // For each string in the 'elements' variable, create a new SelectListItem object
            // that has both its Value and Text properties set to a particular value.
            // This will result in MVC rendering each item as:
            //     <option value="State Name">State Name</option>
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
