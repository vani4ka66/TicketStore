using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TicketStore.Attributes;
using TicketStore.Models.BindingModels.Event;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels.Customer;
using TicketStore.Services;

namespace TicketStore.Controllers
{
    [RoutePrefix("customer")]
    public class CustomerController : Controller
    {
        private CustomerService service;

        public CustomerController()
        {
            this.service = new CustomerService();
        }


        [HttpGet]
        [Route("myprofile")]
        [AllowAnonymous]
        public ActionResult MyProfile()
        {
            string user = this.User.Identity.GetUserName();
            CustomerProfileViewModel view = this.service.GetMyProfile(user);

            return View(view);
        }

        [HttpGet]
        [Route("allcustomers")]
        [AllowAnonymous]
        public ActionResult AllCustomers()
        {
            IEnumerable<Customer> customers = this.service.GetCustomers();

            return View(customers);
        }

        [HttpPost]
        [Route("favorite/{id}")]
        [MyAuthorize(Roles = "Customer")]
        public ActionResult Favorite(EventBindingModel bind)
        {
            string url = "/Event/EventDetails/" + bind.Id;
            if (ModelState.IsValid)
            {
                var user = this.User.Identity.GetUserName();
                this.service.AddFavoriteEvent(user, bind);
            }

            return Redirect(url);
        }

        [HttpPost]
        [Route("removefavorite/{id}")]
        [MyAuthorize(Roles = "Customer")]
        public ActionResult RemoveFavorite(EventBindingModel bind)
        {
            string url = "/Event/EventDetails/" + bind.Id;

            if (ModelState.IsValid)
            {
                var user = this.User.Identity.GetUserName();
                this.service.RemoveFromFavoriteEvent(user, bind);
            }

            return Redirect(url);
        }

        //[HttpPost]
        //[Route("clearhistorylastten")]
        //[MyAuthorize(Roles = "Customer")]
        //public ActionResult ClearHistoryLastTen(CustomerProfileViewModel bind)
        //{
        //    string url = "/Customer/MyProfile/";
        //
        //    if (ModelState.IsValid)
        //    {
        //        var user = this.User.Identity.GetUserName();
        //        this.service.ClearHistoryLastViews(user, bind);
        //    }
        //
        //    return Redirect(url);
        //}

    }
}