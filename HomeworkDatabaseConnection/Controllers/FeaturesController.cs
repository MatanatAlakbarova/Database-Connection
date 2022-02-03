using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkDatabaseConnection.Controllers
{
    public class FeaturesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
