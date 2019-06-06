using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreWebApp.Models.DataModels
{
    //TODO: Review all controllers and classes and remove all un-used usings
    //TODO: Add Validation to properties using data annotations
    //TODO: Set Default value to request date to be 3 days from current date time. 
    //TODO: Populate list to form drop down controls.
    //HACK: something    
    //BUG: Datetime default value is invalid when rendoring create view. 

    public class ServiceRequestDataModel
    {
        [DisplayName("Service Request Type")]
        public List<string> ServiceRequesttype { get; set; }
        //Needs a min length
        public string ServiceRequestDescription { get; set; }
        [DataType(DataType.Date)]
        public DateTime IdealRequestDate { get; set; }
        public bool CustomerConsent { get; set; }
        public List<string> PreferredContactMethod { get; set; }
    }
}
