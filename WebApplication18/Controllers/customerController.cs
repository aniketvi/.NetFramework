using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication18.Models;

namespace WebApplication18.Controllers
{
    public class customerController : Controller
    {
        private ApplicationDbContext dbContext;

        public customerController(ApplicationDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public IActionResult Index()
        {
            List<location> Locations = dbContext.Locations.ToList();
            return View(Locations);
        }
    }
}
