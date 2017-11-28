using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Models.EntityModels;

namespace TicketStore.Models.ViewModels
{
    public class All
    {
        public All()
        {
            this.Events = new HashSet<EntityModels.Event>();
            this.Categories = new HashSet<EntityModels.Category>();
        }

        public ICollection<EntityModels.Category> Categories { get; set; }
        public ICollection<EntityModels.Event> Events { get; set; }

    }
}
