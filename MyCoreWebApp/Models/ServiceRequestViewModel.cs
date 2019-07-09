using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreWebApp.Models
{
    public class ServiceRequestViewModel
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public string Email { get; set; }
        public string ServiceDescription { get; set; }
        public bool CheckBox { get; set; }
    }
}
