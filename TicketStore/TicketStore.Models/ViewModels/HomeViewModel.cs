using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Models.ViewModels
{
    public class HomeViewModel
    {
        public HomeViewModel()
        {
            this.CultureEvents = new HashSet<EntityModels.Event>();
            this.ConcertsEvents = new HashSet<EntityModels.Event>();
        }

        public ICollection<EntityModels.Event> CultureEvents { get; set; }
        public ICollection<EntityModels.Event> ConcertsEvents { get; set; }
    }
}
