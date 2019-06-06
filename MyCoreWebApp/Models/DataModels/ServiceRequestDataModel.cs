using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreWebApp.Models.DataModels
{
    //TODO: Review all controllers and classes and remove all un-used usings
   
    //HACK: For PD; Need to move list builder to an interface and use dependancy injection
    //BUG: Datetime default value is invalid when rendoring create view. 
    public class ServiceRequestDataModel
    {
       //Gets called when instantiating this model to prepopulate list for the view.
        public ServiceRequestDataModel()
        {
            List<RequestDefinitions> mylist = new List<RequestDefinitions>();
            mylist.Add(new RequestDefinitions { RequestTypeId = 1, RequestName = "General Checkup", RequestDescription = "Standard check up includes but not limited to water sampling for chemical balance, equipment review, refilling auto feeders etc."});
            mylist.Add(new RequestDefinitions { RequestTypeId = 2, RequestName = "Maintenance / Repair", RequestDescription = "Troubleshooting foggy water, equipment repair etc." });
            mylist.Add(new RequestDefinitions { RequestTypeId = 3, RequestName = "Cleaning", RequestDescription = "Glass cleaning, water recycling, any other things that can be done to make the tank looking fresh and clean like its brand new."});
            mylist.Add(new RequestDefinitions { RequestTypeId = 4, RequestName = "Equipment", RequestDescription = "Troubleshooting foggy water, equipment repair etc." });
            mylist.Add(new RequestDefinitions { RequestTypeId = 5, RequestName = "Tank Mpdfication", RequestDescription = "This would be for cases like if you need a tank moved or you want to change to a different different size tank." });
            mylist.Add(new RequestDefinitions { RequestTypeId = 6, RequestName = "Other", RequestDescription = "You fill in the blank, this could be unique situations such as troubleshooting new unwanted noises from pumps or just general consulting for future enhancements." });
            RequestTypeInformation = mylist;
        }

        //TODO: Populate list to form drop down controls.
        //TODO: Add Validation to properties using data annotations, value must be greater than 1 and required
        [DisplayName("Service Request Type")]
        public List<string> ServiceRequesttype { get; set; }

        //TODO: Needs a min length validation added and display name
        public string ServiceRequestDescription { get; set; }

        //TODO: Set Default value to request date to be 3 days from current date time to close out bug
        //TODO: Needs display name
        [DataType(DataType.Date)]
        public DateTime IdealRequestDate { get; set; }
        //TODO: Needs display name
        public bool CustomerConsent { get; set; }
        //TODO: Add Validation to properties using data annotations and value can't be null
        //TODO: build list of some type to populate options
        public List<string> PreferredContactMethod { get; set; }

        public List<RequestDefinitions> RequestTypeInformation { get; set; }
    }
    public class RequestDefinitions
    {
        [Display(Name = "Option")]
        public int RequestTypeId { get; set; }
        [Display(Name = "Reqest Type")]
        public string RequestName { get; set; }
        [Display(Name = "Description")]
        public string RequestDescription { get; set; }
    }
}
