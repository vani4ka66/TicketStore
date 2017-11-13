using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TicketStore.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return this.View();
        }

        [HttpGet]
        //[Route("contact")]
        [AllowAnonymous]
        public ActionResult Contact()
        {
            return View();
        }


        [HttpGet]
        [Route("update")]
        [AllowAnonymous]
        public ActionResult Update()
        {
            return View("Index");
        }

        //[HttpGet]
        //[Route("about")]
        //public PartialViewResult About()
        //{
        //    return PartialView("_About");
        //}

        [HttpGet]
        //[Route("purchaseticket")]
        [AllowAnonymous]
        public ActionResult PurchaseTicket()
        {
            return View();
        }


    }
}