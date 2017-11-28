using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Models.EntityModels;

namespace TicketStore.Services
{
    public class HomeService : Service
    {
        public ICollection<Event> GetIndexConcerts()
        {
            var concerts = this.Context.Events.Where(x => x.Category.AllCategoryId == 1 ).OrderByDescending(x=> x.Views).Take(6).ToList();
            return concerts;
        }

        public ICollection<Event> GetIndexCulture()
        {
            var culture = this.Context.Events.Where(x => x.Category.AllCategoryId == 2).OrderByDescending(x => x.Views).Take(6).ToList();
            return culture;
        }

       
    }
}
