using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Models.EntityModels;

namespace TicketStore.Models.BindingModels.Category
{
    public class DeleteCategoryBindingModel
    {

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Name { get; set; }

        //[Required]
        //[Display(Name = "AllCategory_Id")]
        public int? AllCategoryId { get; set; }

        public AllCategory AllCategory { get; set; }
    }
}
