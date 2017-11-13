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

        [HttpGet]
        [Route("eventstable/{id}")]
        [AllowAnonymous]
        public ActionResult EventsTable(int id)
        {
            IEnumerable<EventViewModel> view = this.service.GetAllEvents(id);

            return this.View(view);
        }

        [HttpGet]
        [Route("eventdetails/{id}")]
        [AllowAnonymous]
        public ActionResult EventDetails(int id)
        {
            EventViewModel view = this.service.GetSingleEventDetail(id);
            return View(view);
        }

        [HttpGet]
        [Route("ticketdetails/{id}")]
        [AllowAnonymous]
        public ActionResult TicketDetails(int id)
        {
            EventViewModel view = this.service.GetTicketDetails(id);

            //ViewData["TicketPrices"] = this.service.GetListTicketPrices(id);
            
            return View(view);
        }

        [HttpGet]
        [Route("paymentdetails/{id}")]
        [AllowAnonymous]
        public ActionResult PaymentDetails(int id)
        {
            EventViewModel view = this.service.GetTicketDetails(id);

            return View(view);
        }

        [HttpPost]
        [Route("votenow/{id}")]
        public ActionResult VoteNow(EventBindingModel bind)
        {
            this.service.PostVote(bind);

            string url = "/category/EventDetails/" + bind.Id;

            return Redirect(url);
        }
    }
}