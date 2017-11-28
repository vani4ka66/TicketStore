using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Models.EntityModels
{
    public class Customer
    {
        public Customer()
        {
            this.FavoriteEvents = new HashSet<Event>();
            this.LastTenEvents = new Queue<Event>();

        }

        [Key]
        public int Id { get; set; }

        [Required]
        [Display(Name = "Full Name")]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 5)]
        public string FullName { get; set; }

        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }

        public virtual ApplicationUser User { get; set; }

        public virtual ICollection<Event> FavoriteEvents { get; set; }

        public string Address { get; set; }

        public string Telephone { get; set; }

        //public string CreditCardNumber { get; set; }

        //public string CardHolderName { get; set; }

        public virtual Queue<Event> LastTenEvents { get; set; }



    }
}
