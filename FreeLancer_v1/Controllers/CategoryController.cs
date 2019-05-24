using FreeLancer_v1.Models.Managers;
using FreeLancer_v1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FreeLancer_v1.Controllers
{
    public class CategoryController : Controller
    {

        DatabaseContext db = new DatabaseContext();
        // GET: Category
        public ActionResult Category(int id)
        {
            Expert experts = db.Experts.Where(ex => ex.Sub_Category.topCategoryID == id || ex.abilityID==id).FirstOrDefault();
              
            return View(experts);
        }
        public PartialViewResult GetSubCategory(int id)
        {
            Sub_Category sub_Category = db.Sub_Categories.Where(x => x.topCategoryID == id).FirstOrDefault();
            return PartialView("_PartialPageSubCategory", sub_Category);
        }
    }
}