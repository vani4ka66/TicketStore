using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Data
{
    public class Data
    {
        private static TicketStoreContext context;

        public static TicketStoreContext Context
            => context ?? (context = new TicketStoreContext());
    }
}
