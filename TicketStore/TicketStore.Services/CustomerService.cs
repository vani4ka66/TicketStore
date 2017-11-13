using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
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
    }
}
