using Microsoft.AspNetCore.Mvc;
using NestCod.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NestCod.Areas.Area.Controllers
{
    [Area("Area")]
    public class AdminController : Controller
    {
        private AppDbContext _Context { get; }
        public AdminController(AppDbContext Context)
        {
            _Context = Context;
        }
        public IActionResult Index()
        {
            return View();
        }
        
      
    }
}
