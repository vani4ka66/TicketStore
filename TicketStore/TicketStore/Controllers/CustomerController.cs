using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels.Customer;
using TicketStore.Services;

namespace TicketStore.Controllers
{
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
    }
}