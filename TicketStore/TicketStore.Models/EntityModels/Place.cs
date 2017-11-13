using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Models.EntityModels
{
    public class Place
    {
        private string name;

        public Place()
        {
            this.Prices = new List<int>();
            this.Events = new List<Event>();
        }

        [Key]
        public int Id { get; set; }

        //[Required]
        [StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Name
        {
            get { return this.name; }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException(value, "The name can not be null");
                }

                if (value.Length <= 3 && value.Length >= 50)
                {
                    throw new ArgumentException("Name must be between 3 and 50 symbols long");
                }

                this.name = value;
            }
        }

        public virtual ICollection<int> Prices { get; set; }

        public virtual ICollection<Event> Events { get; set; }
    }
}
