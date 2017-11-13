using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Data;

namespace TicketStore.Services
{
    public abstract class Service
    {
        public Service()
        {
            this.Context = TicketStore.Data.Data.Context;
            //this.Context = new TicketStoreContext();
        }

        protected TicketStoreContext Context { get; }
    }
}
