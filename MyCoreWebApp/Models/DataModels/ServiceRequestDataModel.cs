using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreWebApp.Models.DataModels
{
    public class ServiceRequestDataModel
    {
        public List<string> ServiceRequesttype { get; set; }
        public string ServiceRequestDescription { get; set; }
        public Datetime IdealRequestDate { get; set; }
        public bool CustomerConsent { get; set; }
        public List<string> PreferredContactMethod { get; set; }
    }
}
