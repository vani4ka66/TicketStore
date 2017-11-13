using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Models.BindingModels.Event
{
    public class DeleteEventBindingModel
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }

        public int? CategoryId { get; set; }

        public EntityModels.Category Category { get; set; }
    }
}
