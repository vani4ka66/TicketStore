using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity.Owin;
using TicketStore.Attributes;
using TicketStore.Models.BindingModels.Category;
using TicketStore.Models.BindingModels.Event;
using TicketStore.Services;

namespace TicketStore.Areas.Admin.Controllers
{
    [RouteArea("admin")]
    [RoutePrefix("admin")]
    //[MyAuthorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private AdminService service;
        private ApplicationUserManager _userManager;

        public AdminController()
        {
            this.service = new AdminService();
        }

        public AdminController(ApplicationUserManager usermanager) : this()
        {
            this.UserManager = usermanager;
        }

        public ApplicationUserManager UserManager
        {
            get
            {
                return _userManager ?? HttpContext.GetOwinContext().GetUserManager<ApplicationUserManager>();
            }
            private set
            {
                _userManager = value;
            }
        }


        // GET: Admin/Admin
        [HttpGet]
        [Route("addcategory")]
        public ActionResult AddCategory()
        {
            ViewBag.MainCategoriesNames = this.service.GetMainCategoriesNames();

            return View();
        }

        [HttpPost]
        [Route("addcategory")]
        public ActionResult AddCategory(CategoryBindingModel bind)
        {
            this.service.PostAddCategory(bind);

            string categoryName = this.service.GetCategoryName(bind).Replace(" ", "");

            return RedirectToAction(categoryName, "Category", new { @area = "" });
        }

        [HttpGet]
        [Route("editcategory/{id}")]
        public ActionResult EditCategory(int id)
        {
            CategoryBindingModel view = this.service.GetEditCategory(id);

            ViewBag.MainCategoriesNames = this.service.GetMainCategoriesNames();

            return View(view);
        }

        [HttpPost]
        [Route("editcategory/{id}")]
        public ActionResult EditCategory(CategoryBindingModel bind)
        {
            this.service.PostEditCategory(bind);

            string categoryName = this.service.GetCategoryName(bind).Replace(" ", "");

            return RedirectToAction(categoryName, "Category", new {@area = ""});
        }

        [HttpGet]
        [Route("deletecategory/{id}")]
        public ActionResult DeleteCategory(int id)
        {
            DeleteCategoryBindingModel view = this.service.GetDeleteCategory(id);

            return View(view);
        }

        [HttpPost]
        [Route("deletecategory/{id}")]
        public ActionResult DeleteCategory(CategoryBindingModel bind)
        {
            this.service.PostDeleteCategory(bind);

            string categoryName = this.service.GetCategoryName(bind).Replace(" ", "");

            return RedirectToAction(categoryName, "Category", new {@area = ""});
        }

        [HttpGet]
        [Route("addevent")]
        public ActionResult AddEvent()
        {
            ViewBag.SubCategoriesNames = this.service.GetSubCategoriesNames();

            return View();
        }

        [HttpPost]
        [Route("addevent")]
        public ActionResult AddEvent(EventBindingModel bind)
        {
            this.service.PostAddEvent(bind);

            string url = "/event/EventsTable/" + bind.CategoryId;

            return Redirect(url);
        }

        [HttpGet]
        [Route("editevent/{id}")]
        public ActionResult EditEvent(int id)
        {
            EventBindingModel view = this.service.GetEditEvent(id);

            ViewBag.SubCategoriesNames = this.service.GetSubCategoriesNames();

            return View(view);
        }

        [HttpPost]
        [Route("editevent/{id}")]
        public ActionResult EditEvent(EventBindingModel bind)
        {
            this.service.PostEditEvent(bind);

            string url = "/event/EventsTable/" + bind.CategoryId;

            return  Redirect(url);
        }

        [HttpGet]
        [Route("deleteevent/{id}")]
        public ActionResult DeleteEvent(int id)
        {
            DeleteEventBindingModel view = this.service.GetDeleteEvent(id);

            return View(view);
        }

        [HttpPost]
        [Route("deleteevent/{id}")]
        public ActionResult DeleteEvent(DeleteEventBindingModel bind)
        {
            this.service.PostDeleteEvent(bind);

            string url = "/event/EventsTable/" + bind.CategoryId;

            return Redirect(url);
        }
    }
}