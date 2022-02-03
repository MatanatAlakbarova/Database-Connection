
using HomeworkDatabaseConnection.DataAccessLayer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HomeworkDatabaseConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public IActionResult Index()
        {        
           var products = _dbContext.Products.Include(x=>x.Category).ToList();   
            return View(products);
        }
    }
}
