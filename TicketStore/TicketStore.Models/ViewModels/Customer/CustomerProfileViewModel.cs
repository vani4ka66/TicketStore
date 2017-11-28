using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Models.EntityModels;

namespace TicketStore.Models.ViewModels.Customer
{
    public class CustomerProfileViewModel
    {
        public CustomerProfileViewModel()
        {
            this.FavoriteEvents = new HashSet<EntityModels.Event>();
            this.LastTenEvents = new Queue<EntityModels.Event>();

        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        public string FullName { get; set; }

        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<EntityModels.Event> FavoriteEvents { get; set; }

        public string Address { get; set; }

        public string Telephone { get; set; }

        //public string CreditCardNumber { get; set; }

        //public string CardHolderName { get; set; }

        public virtual Queue<EntityModels.Event> LastTenEvents { get; set; }

    }
}
