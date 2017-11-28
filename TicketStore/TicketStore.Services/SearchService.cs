using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels;

namespace TicketStore.Services
{
    public class SearchService : Service
    {
        public ICollection<Category> GetAllCategories()
        {
            return this.Context.Categories.ToList();
        }

        public ICollection<Event> GetAllEvents()
        {
            return this.Context.Events.OrderByDescending(x => x.Views).ToList();
        }

        public IEnumerable<Category> SearchCategory(string keyword)
        {
            return this.Context.Categories.Where(x => x.Name.Contains(keyword)).ToList();
        }

        public IEnumerable<Event> SearchEvent(string keyword)
        {
            return this.Context.Events.Where(x => x.Name.Contains(keyword)).OrderByDescending(x => x.Views).ToList();
        }

        public IEnumerable<Event> SearchLocation(string keyword)
        {
            return this.Context.Events.Where(x => x.Location.Contains(keyword)).OrderByDescending(x => x.Views).ToList();
        }
    }
}
