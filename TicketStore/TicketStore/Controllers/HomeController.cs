using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels;
using TicketStore.Services;

namespace TicketStore.Controllers
{
    [RoutePrefix("home")]
    public class HomeController : Controller
    {
        public HomeService service;

        //public HomeController()
        //{
        //    
        //}

        public HomeController()
        {
            this.service = new HomeService();
        }

        [Route("index")]
        public ActionResult Index()
        {
            HomeViewModel view = new HomeViewModel()
            {
                ConcertsEvents = this.service.GetIndexConcerts(),
                CultureEvents = this.service.GetIndexCulture().ToList()
            };

            return this.View(view);
        }

        [HttpGet]
        //[Route("contact")]
        [AllowAnonymous]
        public ActionResult Contact()
        {
            return View();
        }


        [HttpGet]
        [Route("about")]
        [AllowAnonymous]
        public ActionResult About()
        {
            return View();
        }

        [HttpPost]
        [Route("concertsindex")]
        public PartialViewResult ConcertsIndex()
        {
            IEnumerable<Event> events = this.service.GetIndexConcerts();

            return this.PartialView("_ConcertsIndexPartialView", events);
        }




    }
}