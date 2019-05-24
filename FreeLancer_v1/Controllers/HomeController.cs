using FreeLancer_v1.Models;
using FreeLancer_v1.Models.Managers;
using FreeLancer_v1.ViewModel;
using FreeLancer_v1.ViewModel.HomePageViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Mvc;

namespace FreeLancer_v1.Controllers
{
    public class HomeController : Controller
    {
        
        // GET: Home
        public ActionResult HomePage()
        {
            
            return View();
        }

        public ActionResult About()
        {
            return View();
        }

        public ActionResult Contact()
        {
            return View();
        }

        public ActionResult Kesfet()
        {
            DatabaseContext db = new DatabaseContext();
            ViewModelClass viewModelClass = new ViewModelClass();
            viewModelClass.HomeSubCategories = db.Sub_Categories.ToList();
            viewModelClass.HomeCategory = db.Categories.ToList();
            viewModelClass.HomeExpert = db.Experts.ToList();
            return View(viewModelClass);
        }
        
    }
}