using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Models.EntityModels;

namespace TicketStore.Models.ViewModels.Category
{
    public class CategoryViewModel
    {
        public CategoryViewModel()
        {
            this.Events = new List<EntityModels.Event>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Name { get; set; }

        //[Required]
        public string Image { get; set; }

        public virtual ICollection<EntityModels.Event> Events { get; set; }

        //[Required]
        //[Display(Name = "AllCategory_Id")]
        public int? AllCategoryId { get; set; }

        public AllCategory AllCategory { get; set; }
    }
}
