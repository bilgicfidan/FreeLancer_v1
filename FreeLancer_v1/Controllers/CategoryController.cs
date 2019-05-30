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
            ViewModelClass modelClass = new ViewModelClass();
            var experts = db.Experts.Where(ex => ex.Sub_Category.topCategoryID == id || ex.abilityID==id).Select(s=>new Expert() { abilityID =s.abilityID , name=s.name}).ToList();
            modelClass.HomeExpert = experts;
            var sub_Category = db.Sub_Categories.Where(x => x.topCategoryID == id).Select(s => new Sub_Category() { topCategoryID = s.topCategoryID, name = s.name }).ToList();
            modelClass.HomeSubCategories = sub_Category;
            //ViewData["kategoriler"] = sub_Category;
            //ViewData["expertler"] = experts;

            return View(modelClass);
        }
        public PartialViewResult GetSubCategory(int id)
        {
            Sub_Category sub_Category = db.Sub_Categories.Where(x => x.topCategoryID == id).FirstOrDefault();
            return PartialView("_PartialPageSubCategory", sub_Category);
        }
    }
}