using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel;

namespace MyCoreWebApp.Models
{
    public class ServiceRequestViewModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string ServiceDescription { get; set; }
        public bool CheckBox { get; set; }
        //Dropdown list for selecting a request type
        [DisplayName("Select A Request Type")]
        public IEnumerable<SelectListItem> RequestTypeDdl { get; set; }
        //This is for storing the value selected in the  Request type dropdown list
        public string RequestType { get; set; }
    }
}
