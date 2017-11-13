using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TicketStore.Models.BindingModels.Event;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels.Category;

namespace TicketStore.Services
{
    public class CategoryService : Service
    {
        public IEnumerable<CategoryViewModel> GetAllConcerts()
        {
            IEnumerable<Category> categories = this.Context.Categories.Where(c => c.AllCategory.Name == "Concerts");

            IEnumerable<CategoryViewModel> view =
                Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);

            return view;
        }

        public IEnumerable<CategoryViewModel> GetAllCulture()
        {
            IEnumerable<Category> categories = this.Context.Categories.Where(c => c.AllCategory.Name == "Culture");

            IEnumerable<CategoryViewModel> view =
                Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);

            return view;

        }

        public IEnumerable<CategoryViewModel> GetAllSports()
        {
            IEnumerable<Category> categories = this.Context.Categories.Where(c => c.AllCategory.Name == "Sport");

            IEnumerable<CategoryViewModel> view =
                Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);

            return view;
        }

        public IEnumerable<CategoryViewModel> GetAllOtherEvents()
        {
            IEnumerable<Category> categories = this.Context.Categories.Where(c => c.AllCategory.Name == "Other Events");

            IEnumerable<CategoryViewModel> view =
                Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);

            return view;

        }

        public IEnumerable<EventViewModel> GetAllEvents(int id)
        {
            IEnumerable<Event> events = this.Context.Events.Where(c => c.Category.Id == id);

            IEnumerable<EventViewModel> view =
              Mapper.Map<IEnumerable<Event>, IEnumerable<EventViewModel>>(events);

            return view;
        }

        public EventViewModel GetSingleEventDetail(int id)
        {
            Event singleEvent = this.Context.Events.Find(id);

            EventViewModel view =
                Mapper.Map<Event, EventViewModel>(singleEvent);

            return view;
        }

        public EventViewModel GetTicketDetails(int id)
        {
            Event singleEvent = this.Context.Events.Find(id);

            EventViewModel view =
                Mapper.Map<Event, EventViewModel>(singleEvent);

            return view;
        }

       //public object GetListTicketPrices(int id)
       //{
       //
       //    Event singleEvent = this.Context.Events.Find(id);
       //    ICollection<int> list = singleEvent.Place.Prices.ToList();
       //    list.Add(20);
       //
       //    return list;
       //}
        public void PostVote(EventBindingModel bind)
        {
            Event singleEvent = this.Context.Events.Find(bind.Id);

            if (singleEvent.Vote == null)
            {
                singleEvent.Vote = 0;
            }

            singleEvent.Vote++;

            Mapper.Instance.Map<EventBindingModel, Event>(bind);
            this.Context.SaveChanges();

        }
    }
}
