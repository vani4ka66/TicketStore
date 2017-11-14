using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketStore.Models.BindingModels.Event;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels.Category;
using TicketStore.Services;
//using TicketStore.Services.Interfaces;

namespace TicketStore.Controllers
{
    [RoutePrefix("category")]
    public class CategoryController : Controller
    {
        private CategoryService service;

        //public CategoryController()
        //{
        //}

        public CategoryController()
        {
            this.service = new CategoryService();
        }

        [HttpGet]
        [Route("concerts")]
        [AllowAnonymous]
        public ActionResult Concerts()
        {

            IEnumerable<CategoryViewModel> view = this.service.GetAllConcerts();

            return View(view);
        }

        [HttpGet]
        [Route("culture")]
        [AllowAnonymous]
        public ActionResult Culture()
        {
            IEnumerable<CategoryViewModel> view = this.service.GetAllCulture();

            return View(view);
        }

        [HttpGet]
        [Route("sport")]
        [AllowAnonymous]
        public ActionResult Sport()
        {
            IEnumerable<CategoryViewModel> view = this.service.GetAllSports();

            return View(view);
        }

        [HttpGet]
        [Route("otherevents")]
        [AllowAnonymous]
        public ActionResult OtherEvents()
        {
            IEnumerable<CategoryViewModel> view = this.service.GetAllOtherEvents();

            return View(view);
        }

       
    }
}