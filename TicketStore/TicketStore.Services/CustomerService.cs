using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TicketStore.Models.BindingModels.Category;
using TicketStore.Models.BindingModels.Event;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels.Customer;

namespace TicketStore.Services
{
    public class CustomerService : Service
    {
        public IEnumerable<Customer> GetCustomers()
        {
            return this.Context.Customers;
        }

        public CustomerProfileViewModel GetMyProfile(string user)
        {

            Customer customer = this.Context.Customers.FirstOrDefault(x => x.User.UserName == user);
            customer.UserName = user;
            customer.Email = user;

            CustomerProfileViewModel view = Mapper.Map<Customer, CustomerProfileViewModel>(customer);

            return view;

        }

        public void AddFavoriteEvent(string user, EventBindingModel bind)
        {
            Event singleEvent = this.Context.Events.Find(bind.Id);
            singleEvent.IsFavorite = true;

            Mapper.Instance.Map<EventBindingModel, Event>(bind);

            Customer customer = this.Context.Customers.FirstOrDefault(x => x.User.UserName == user);

            customer.FavoriteEvents.Add(singleEvent);
            
            this.Context.SaveChanges();
        }

        public void RemoveFromFavoriteEvent(string user, EventBindingModel bind)
        {
            Event singleEvent = this.Context.Events.Find(bind.Id);
            singleEvent.IsFavorite = false;

            Mapper.Instance.Map<EventBindingModel, Event>(bind);

            Customer customer = this.Context.Customers.FirstOrDefault(x => x.User.UserName == user);

            customer.FavoriteEvents.Remove(singleEvent);
            this.Context.SaveChanges();
           
        }

        //public void ClearHistoryLastViews(string user, CustomerProfileViewModel bind)
        //{
        //    Customer customer = this.Context.Customers.FirstOrDefault(x => x.User.UserName == user);
        //    customer.LastTenEvents.Clear();
        //    Mapper.Instance.Map<Customer, CustomerProfileViewModel>(customer);
        //
        //    this.Context.SaveChanges();
        //}
    }
}
