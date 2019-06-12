using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreWebApp.Models.DataModels
{
    public class HomeDataModel
    {
        public IEnumerable<SelectListItem> OurServicesList { get; set; }
        public string ServiceName { get; set; }

        public IEnumerable<string> CardContentList { get; set; }      

    }
}
