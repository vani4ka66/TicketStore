using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketStore.Models.EntityModels;

namespace TicketStore.Models.ViewModels.Event
{
    public class EventViewModel
    {

      //public EventViewModel()
      //{
      //    this.Place.Prices = new List<int>();
      //}

        [Key]
        public int Id { get; set; }

        //[Required]
        //[StringLength(50, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 3)]
        public string Name { get; set; }

        //[Required]
        public string Image { get; set; }

        public string Content { get; set; }

        public string Title { get; set; }

        public string DateDetails { get; set; }

        public string Hour { get; set; }

        public string CityCountry { get; set; }

        public string Prices { get; set; }

        public string Location { get; set; }

        //[Required]
        [Display(Name = "Category_Id")]
        public int? CategoryId { get; set; }

        public EntityModels.Category Category { get; set; }

        public AllCategory AllCategory { get; set; }

        public int? Vote { get; set; }

        public int? Views { get; set; }

        public bool IsFavorite { get; set; }

        public DateTime ViewTime { get; set; }



    }
}
