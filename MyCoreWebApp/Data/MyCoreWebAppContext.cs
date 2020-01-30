using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MyCoreWebApp.Models.DemoModel;

namespace MyCoreWebApp.Models
{
    public class MyCoreWebAppContext : DbContext
    {
        public MyCoreWebAppContext (DbContextOptions<MyCoreWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<MyCoreWebApp.Models.DemoModel.StudentModel> StudentModel { get; set; }
    }
}
