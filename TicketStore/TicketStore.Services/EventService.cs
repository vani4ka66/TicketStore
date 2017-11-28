using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TicketStore.Models.BindingModels.Event;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels.Category;
using TicketStore.Models.ViewModels.Customer;
using TicketStore.Models.ViewModels.Event;

namespace TicketStore.Services
{
    public class EventService : Service
    {
        public IEnumerable<EventViewModel> GetAllEvents(int id)
        {
            IEnumerable<Event> events = this.Context.Events.Where(c => c.Category.Id == id).OrderByDescending(x => x.Views).ToList();

            IEnumerable<EventViewModel> view =
              Mapper.Map<IEnumerable<Event>, IEnumerable<EventViewModel>>(events);

            return view;
        }


        public EventViewModel GetSingleEventDetail(string user, int id)
        {
            Event singleEvent = this.Context.Events.Find(id);

            singleEvent.ViewTime = DateTime.Now;
            
            if (singleEvent.Views == null)
            {
                singleEvent.Views = 0;
            }
            singleEvent.Views++;

            Customer customer = this.Context.Customers.FirstOrDefault(x => x.User.UserName == user);

            customer.LastTenEvents.Enqueue(singleEvent);


            if (customer.LastTenEvents.Count >= 11)
            {
                customer.LastTenEvents.Dequeue();
            }

            Mapper.Map<Customer, CustomerProfileViewModel>(customer);


            EventViewModel view =
                Mapper.Map<Event, EventViewModel>(singleEvent);

            this.Context.SaveChanges();
            return view;
        }

        public EventViewModel GetTicketDetails(int id)
        {
            Event singleEvent = this.Context.Events.Find(id);

            EventViewModel view =
                Mapper.Map<Event, EventViewModel>(singleEvent);

            return view;
        }

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
