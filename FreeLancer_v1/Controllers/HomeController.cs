using FreeLancer_v1.Models;
using FreeLancer_v1.Models.Managers;
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
            DatabaseContext db = new DatabaseContext();
            List<Expert> experts = db.Experts.ToList();
            return View(experts);
        }
    }
}