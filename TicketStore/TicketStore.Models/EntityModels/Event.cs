using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketStore.Models.EntityModels
{
    public class Event
    {
        private string name;
        private decimal price;

       public Event()
       {
           //this.Prices = new List<int>();
           this.ViewTime = DateTime.Now;
       }

        [Key]
        public int Id { get; set; }

        //[Required]
        //[StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        //public string Name
        //{
          //  get { return this.name; }

           // set
           // {
           //     if (string.IsNullOrEmpty(value))
           //     {
           //         throw new ArgumentNullException(value, "The name can not be null");
           //     }
           //
           //     if (value.Length <= 3 && value.Length >= 50)
           //     {
           //         throw new ArgumentException("Name must be between 3 and 50 symbols long");
           //     }
           //
           //     this.name = value;
           // }
       // }

        //[Required]

        public string Name { get; set; }

        public string Image { get; set; }

        //[Required]
        //public decimal Price
        //{
        //    get { return this.price; }
        //
        //    set
        //    {
        //        if (value < 0)
        //        {
        //            throw new ArgumentException("Your value must be a positive number.");
        //        }
        //
        //        this.price = value;
        //    }
        //}

        public string Content { get; set; }

        public string Title { get; set; }

        public string DateDetails { get; set; }

        public string Hour { get; set; }

        public string Location { get; set; }

        public string Prices { get; set; }

        public string CityCountry { get; set; }

        //[Required]
        [Display(Name = "Category_Id")]
        public int? CategoryId { get; set; }

        public Category Category { get; set; }

        public AllCategory AllCategory { get; set; }

        public int? Vote { get; set; }

        public int? Views { get; set; }

        public bool IsFavorite { get; set; }

        public DateTime ViewTime { get; set; }



    }
}
