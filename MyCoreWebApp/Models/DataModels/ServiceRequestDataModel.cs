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
            mylist.Add(new RequestDefinitions { RequestTypeId = 1, RequestName = "General Checkup", RequestDescription = "Standard check up includes but not limited to water sampling for chemical balance, equipment review, refilling auto feeders etc." });
            mylist.Add(new RequestDefinitions { RequestTypeId = 2, RequestName = "Maintenance / Repair", RequestDescription = "Troubleshooting foggy water, equipment repair etc." });
            mylist.Add(new RequestDefinitions { RequestTypeId = 3, RequestName = "Cleaning", RequestDescription = "Glass cleaning, water recycling, any other things that can be done to make the tank looking fresh and clean like its brand new." });
            mylist.Add(new RequestDefinitions { RequestTypeId = 4, RequestName = "Equipment", RequestDescription = "Troubleshooting foggy water, equipment repair etc." });
            mylist.Add(new RequestDefinitions { RequestTypeId = 5, RequestName = "Tank Modfication", RequestDescription = "This would be for cases like if you need a tank moved or you want to change to a different different size tank." });
            mylist.Add(new RequestDefinitions { RequestTypeId = 6, RequestName = "Other", RequestDescription = "You fill in the blank, this could be unique situations such as troubleshooting new unwanted noises from pumps or just general consulting for future enhancements." });
            RequestTypeInformation = mylist;

            List<requestTypeOptions> Dropdown = new List<requestTypeOptions>();
            Dropdown.Add(new requestTypeOptions { ID = 1, requestname = "General Checkup" });
            Dropdown.Add(new requestTypeOptions { ID = 2, requestname = "Maintenence" });
            Dropdown.Add(new requestTypeOptions { ID = 3, requestname = "Cleaning" });
            Dropdown.Add(new requestTypeOptions { ID = 4, requestname = "Equipment" });
            Dropdown.Add(new requestTypeOptions { ID = 5, requestname = "Tank Modification" });
            Dropdown.Add(new requestTypeOptions { ID = 6, requestname = "Other" });
            ServiceRequesttype = Dropdown;
        }
        public Gender StudentGender { get; set; }

        //TODO: Populate list to form drop down controls.
        //I dont know what list this is taklking about
        [DisplayName("Service Request Type")]
        [Required(ErrorMessage = "please select a service type")]
        public List<requestTypeOptions> ServiceRequesttype { get; set; }


        [DisplayName("Service Description")]
        [MinLength(1)]
        [Required(ErrorMessage = "Please enter a brief summary of the request")]
        public string ServiceRequestDescription { get; set; }

        [DisplayName("Select a Date for Service")]
        [DataType(DataType.Date)]
        public DateTime IdealRequestDate { get; set; }
        
        
        
        [DisplayName("Customer Consent")]
        public bool CustomerConsent { get; set; }
        //TODO: Add Validation to properties using data annotations and value can't be null
        
        public List<string> GeneralCheckup { get; set; }
        public List<string> Maintenence { get; set; }
        public List<string> Cleaning { get; set; }
        public List<string> Equipment { get; set; }
        public List<string> TankModification { get; set; }
        public List<string> other { get; set; }
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
    //for the request ddl 
    public class requestTypeOptions
    {
        //value of the type selected
        public int ID { get; set; }
        public string requestname { get; set; }
    }
    public enum Gender
    {
        GeneralCheckup,
        Maintenence,
        Cleaning,
        Equipment,
        TankModification,
        other,

    }

}
