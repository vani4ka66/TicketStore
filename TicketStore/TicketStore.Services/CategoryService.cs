using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using TicketStore.Models.BindingModels.Event;
using TicketStore.Models.EntityModels;
using TicketStore.Models.ViewModels.Category;

namespace TicketStore.Services
{
    public class CategoryService : Service
    {
        public IEnumerable<CategoryViewModel> GetAllConcerts()
        {
            IEnumerable<Category> categories = this.Context.Categories.Where(c => c.AllCategory.Name == "Concerts");

            IEnumerable<CategoryViewModel> view =
                Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);

            return view;
        }

        public IEnumerable<CategoryViewModel> GetAllCulture()
        {
            IEnumerable<Category> categories = this.Context.Categories.Where(c => c.AllCategory.Name == "Culture");

            IEnumerable<CategoryViewModel> view =
                Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);

            return view;

        }

        public IEnumerable<CategoryViewModel> GetAllSports()
        {
            IEnumerable<Category> categories = this.Context.Categories.Where(c => c.AllCategory.Name == "Sport");

            IEnumerable<CategoryViewModel> view =
                Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);

            return view;
        }

        public IEnumerable<CategoryViewModel> GetAllOtherEvents()
        {
            IEnumerable<Category> categories = this.Context.Categories.Where(c => c.AllCategory.Name == "Other Events");

            IEnumerable<CategoryViewModel> view =
                Mapper.Map<IEnumerable<Category>, IEnumerable<CategoryViewModel>>(categories);

            return view;

        }
    }
}
