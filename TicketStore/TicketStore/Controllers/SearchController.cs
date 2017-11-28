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
    [RoutePrefix("search")]
    public class SearchController : Controller
    {

        private SearchService service;

        //public SearchController()
        //{
            
        //}

        public SearchController()
        {
            this.service = new SearchService();
        }

        [HttpGet]
        [Route("searchform")]
        public ActionResult SearchForm()
        {
            All view = new All()
            {
                Categories = this.service.GetAllCategories(),
                Events = this.service.GetAllEvents().ToList()
            };

            return this.View(view);
        }

        // GET: Search
        [HttpPost]
        [Route("searchcategory")]
        public PartialViewResult SearchCategory(string keyword)
        {
            IEnumerable<Category> category = this.service.SearchCategory(keyword);

            return this.PartialView("_CategorySearch", category);
        }

        [HttpPost]
        [Route("searchevent")]
        public PartialViewResult SearchEvent(string keywordEvent)
        {
            IEnumerable<Event> events = this.service.SearchEvent(keywordEvent);

            return this.PartialView("_EventSearch", events);
        }

        [HttpPost]
        [Route("searchlocation")]
        public PartialViewResult SearchLocation(string keywordLocation)
        {
            IEnumerable<Event> events = this.service.SearchLocation(keywordLocation);

            return this.PartialView("_LocationSearch", events);
        }
    }
}