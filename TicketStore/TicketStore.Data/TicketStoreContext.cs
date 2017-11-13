using Microsoft.AspNet.Identity.EntityFramework;
using TicketStore.Models.EntityModels;

namespace TicketStore.Data
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class TicketStoreContext : IdentityDbContext<ApplicationUser>
    {
        public TicketStoreContext()
            : base("TicketStoreContext", throwIfV1Schema: false)
        {
        }

        public virtual DbSet<Customer> Customers { get; set; }

        public virtual DbSet<Category> Categories { get; set; }

        public virtual DbSet<Event> Events { get; set; }

        //public virtual DbSet<Place> Places { get; set; }

        public virtual DbSet<AllCategory> AllCategories { get; set; }

        public static TicketStoreContext Create()
        {
            return new TicketStoreContext();
        }
    }

}