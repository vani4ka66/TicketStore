using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TicketStore.Models.BindingModels.Event;
using TicketStore.Models.ViewModels.Category;
using TicketStore.Models.ViewModels.Event;
using TicketStore.Services;

namespace TicketStore.Controllers
{
    [RoutePrefix("event")]
    public class EventController : Controller
    {
        private EventService service;

        //public CategoryController()
        //{
        //}

        public EventController()
        {
            this.service = new EventService();
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
            string user = this.User.Identity.GetUserName();

            EventViewModel view = this.service.GetSingleEventDetail(user, id);
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

            string url = "/event/EventDetails/" + bind.Id;

            return Redirect(url);
        }
    }
}