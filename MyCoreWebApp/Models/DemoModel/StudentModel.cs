using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace MyCoreWebApp.Models.DemoModel
{ // using https://www.completecsharptutorial.com/asp-net-mvc5/asp-net-mvc-5-httpget-and-httppost-method-with-example.php as a source 
    public class StudentModel
    {
        [DisplayName("Identity")]
        public int Id { get; set; }
        public string Name { get; set; }
    }
} 
