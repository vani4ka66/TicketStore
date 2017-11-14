using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using AutoMapper;
using TicketStore.Models.BindingModels.Category;
using TicketStore.Models.BindingModels.Event;
using TicketStore.Models.EntityModels;

namespace TicketStore.Services
{
    public class AdminService : Service
    {
        public object GetMainCategoriesNames()
        {
            return this.Context.AllCategories.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name,

            }).ToList();

        }

        public object GetSubCategoriesNames()
        {
            return this.Context.Categories.Select(x => new SelectListItem
            {
                Value = x.Id.ToString(),
                Text = x.Name,

            }).ToList();
        }

        public string GetCategoryName(CategoryBindingModel bind)
        {
            string name = this.Context.AllCategories.Find(bind.AllCategoryId).Name;

            return name;
        }

       //public object GetPlacesNames()
       //{
       //
       //    return this.Context.Places.Select(x => new SelectListItem
       //    {
       //        Value = x.Id.ToString(),
       //        Text = x.Name,
       //
       //    }).ToList();
       //}

        public void PostAddCategory(CategoryBindingModel bind)
        {
            Category category = Mapper.Instance.Map<CategoryBindingModel, Category>(bind);

            category.AllCategoryId = bind.AllCategoryId;

            AllCategory mainCategories = this.Context.AllCategories.Find(bind.AllCategoryId);

            mainCategories.Categories.Add(category);

            this.Context.Categories.Add(category);
            this.Context.SaveChanges();
        }

        public CategoryBindingModel GetEditCategory(int id)
        {
            return Mapper.Instance.Map<Category, CategoryBindingModel>(Context.Categories.Find(id));
        }

        public void PostEditCategory(CategoryBindingModel bind)
        {
            Category category = this.Context.Categories.Find(bind.Id);

            category.Name = bind.Name;
            category.Image = bind.Image;
            category.AllCategoryId = bind.AllCategoryId;

            category = Mapper.Instance.Map<CategoryBindingModel, Category>(bind);
            this.Context.SaveChanges();
        }

        public DeleteCategoryBindingModel GetDeleteCategory(int id)
        {
            return Mapper.Instance.Map<Category, DeleteCategoryBindingModel>(Context.Categories.Find(id));
        }

        public void PostDeleteCategory(CategoryBindingModel bind)
        {
            Category category = this.Context.Categories.Find(bind.Id);

            Mapper.Instance.Map<CategoryBindingModel, Category>(bind);

            this.Context.Categories.Remove(category);

            this.Context.SaveChanges();
        }

        public void PostAddEvent(EventBindingModel bind)
        {
            Event singleEvent = Mapper.Instance.Map<EventBindingModel, Event>(bind);

            singleEvent.CategoryId = bind.CategoryId;
            //singleEvent.PlaceId = bind.PlaceId;

            Category categories = this.Context.Categories.Find(bind.CategoryId);
            //Place place = this.Context.Places.Find(bind.PlaceId);

            //singleEvent.Place = place;

            //place.Events.Add(singleEvent);

            categories.Events.Add(singleEvent);

            this.Context.Events.Add(singleEvent);
            this.Context.SaveChanges();
        }

        public EventBindingModel GetEditEvent(int id)
        {
            return Mapper.Instance.Map<Event, EventBindingModel>(Context.Events.Find(id));
        }

        public void PostEditEvent(EventBindingModel bind)
        {
            Event singleEvent = this.Context.Events.Find(bind.Id);

            singleEvent.Name = bind.Name;
            singleEvent.Image = bind.Image;
            singleEvent.Title = bind.Title;
            singleEvent.Content = bind.Content;
            singleEvent.DateDetails = bind.DateDetails;
            singleEvent.Hour = bind.Hour;
            singleEvent.Location = bind.Location;
            singleEvent.Prices = bind.Prices;
            //singleEvent.PlaceId = bind.PlaceId;
            singleEvent.CityCountry = bind.CityCountry;
            singleEvent.CategoryId = bind.CategoryId;
            singleEvent.Vote = bind.Vote;

            singleEvent = Mapper.Instance.Map<EventBindingModel, Event>(bind);
            this.Context.SaveChanges();
        }

        public DeleteEventBindingModel GetDeleteEvent(int id)
        {
            return Mapper.Instance.Map<Event, DeleteEventBindingModel>(Context.Events.Find(id));
        }

        public void PostDeleteEvent(DeleteEventBindingModel bind)
        {
            Event singleEvent = this.Context.Events.Find(bind.Id);

            Mapper.Instance.Map<DeleteEventBindingModel, Event>(bind);

            this.Context.Events.Remove(singleEvent);
            this.Context.SaveChanges();
        }

        
    }
}
