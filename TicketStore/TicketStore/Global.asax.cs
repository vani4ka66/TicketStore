using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using AutoMapper;
using TicketStore.Models.BindingModels.Category;
using TicketStore.Models.BindingModels.Event;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels.Account;
using TicketStore.Models.ViewModels.Category;
using TicketStore.Models.ViewModels.Customer;

namespace TicketStore
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            this.ConfigureMapper();
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void ConfigureMapper()
        {
            Mapper.Initialize(expression =>
            {
                expression.CreateMap<RegisterViewModel, Customer>();
                expression.CreateMap<ApplicationUser, CustomerProfileViewModel>();
                expression.CreateMap<Customer, CustomerProfileViewModel>();
                expression.CreateMap<Category, CategoryViewModel>();
                expression.CreateMap<CategoryBindingModel, Category>();
                expression.CreateMap<Event, EventViewModel>();
                expression.CreateMap<Event, EventBindingModel>();
                expression.CreateMap<EventBindingModel, Event>();
                expression.CreateMap<Category, CategoryBindingModel>();
                expression.CreateMap<Category, DeleteCategoryBindingModel>();
                expression.CreateMap<Event, DeleteEventBindingModel>();
                expression.CreateMap<DeleteEventBindingModel, Event>();







            });
        }
    }
}
