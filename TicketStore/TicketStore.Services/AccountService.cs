using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels.Account;

namespace TicketStore.Services
{
    public class AccountService : Service
    {
        public void CreateCustomer(ApplicationUser user, RegisterViewModel model)
        {
            Customer customer = Mapper.Instance.Map<RegisterViewModel, Customer>(model);
            //Customer customer = Mapper.Map< Customer>(model);

            ApplicationUser currentUser = this.Context.Users.Find(user.Id);

            if (currentUser != null)
            {
                customer.User = currentUser;
            }

            this.Context.Customers.Add(customer);
            this.Context.SaveChanges();
        }

        public int CheckUsersCount()
        {
            return this.Context.Users.Count();
        }
    }
}
