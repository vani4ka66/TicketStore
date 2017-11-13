using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using TicketStore.Models.EntityModels;

namespace TicketStore.Data.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TicketStoreContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            this.AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TicketStoreContext context)
        {

            if (!context.Roles.Any(role => role.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manage = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Admin");
                manage.Create(role);
            }

            if (!context.Roles.Any(role => role.Name == "Customer"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manage = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole("Customer");
                manage.Create(role);
            }

            //context.Places.AddOrUpdate(
            //   
            //   new Place()
            //   {
            //       Id = 1,
            //       Name = "Vasil Levski Stadium",
            //       Prices = new List<int>()
            //       {
            //           20, 30, 35, 40, 45, 55
            //       }
            //   },
            //   new Place()
            //   {
            //       Id = 2,
            //       Name = "Arena Armeec",
            //
            //       Prices = new List<int>()
            //       {
            //         50, 60, 80, 90, 100
            //       }
            //   });

            context.AllCategories.AddOrUpdate(

                new AllCategory()
                {
                    Id = 1,
                    Name = "Concerts",

                    Categories = new List<Category>()
                    {
                        new Category()
                        {
                            Name = "Rock",
                            Image = "../../Content/images/concerts/Rock.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Guns 'N' Roses",
                                    Image = "../../Content/images/index/guns-n-roses.jpg",
                                    Place = "Arena Armeec",
                                    DateDetails = "Friday, 03 Nov 2017",
                                    Title = "Tle Ones Guns and Roses",
                                    Content = "yfglwjrgfo;reihgvekjjdhvwihvwhnwliherrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrrvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvvv",
                                    CityCountry = "Bulgaria / Sofia",
                                    Hour = "21:45 PM"
                                },

                                new Event()
                                {
                                    Name = "Deep Purple",
                                    Image = "../../Content/images/index/deep-purple.jpg",
                                },

                                new Event()
                                {
                                    Name = "Scorpions",
                                    Image = "../../Content/images/index/scorpions.jpg",
                                },

                                new Event()
                                {
                                    Name = "Katy Perry",
                                    Image = "../../Content/images/index/katyperry.jpg",
                                },

                                new Event()
                                {
                                    Name = "Ed Sheeran",
                                    Image = "../../Content/images/index/ed.jpg",
                                },
                            },

                        },

                        new Category()
                        {
                            Name = "Pop",
                            Image = "../../Content/images/concerts/Pop.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "Bruno Mars",
                                    Image = "../../Content/images/index/BrunoMars.jpg",
                                },

                                new Event()
                                {
                                    Name = "Depeche Mode",
                                    Image = "../../Content/images/index/depechemode.jpg",
                                },

                                new Event()
                                {
                                    Name = "Lepa Brena",
                                    Image = "../../Content/images/index/LepaBrena.jpg",
                                },

                                new Event()
                                {
                                    Name = "Lara Fabian",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "Lady Gaga",
                                    Image = "../../Content/images/index/gaga.jpg",
                                },

                                new Event()
                                {
                                    Name = "Rag'N'Bone Man",
                                    Image = "../../Content/images/index/RagNBone.jpg",
                                },
                            },
                        },

                        new Category()
                        {
                            Name = "Jazz",
                            Image = "../../Content/images/concerts/Jazz.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "five",
                                    Image = "../../Content/images/index/Bohemi.jpg",
                                },

                                new Event()
                                {
                                    Name = "six",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            },
                        },
                        new Category()
                        {
                            //Id = 10,
                            Name = "Hard & Heavy",
                            Image = "../../Content/images/concerts/Heavy.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "seven",
                                    Image = "../../Content/images/index/Bohemi.jpg",
                                },

                                new Event()
                                {
                                    Name = "eight",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            },
                        },

                        new Category()
                        {
                            //Id = 11,
                            Name = "Punk",
                            Image = "../../Content/images/concerts/Punk.gif",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "nine",
                                    Image = "../../Content/images/index/Bohemi.jpg",
                                },

                                new Event()
                                {
                                    Name = "ten",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            },
                        },

                        new Category()
                        {
                            //Id = 12,
                            Name = "Festival",
                            Image = "../../Content/images/concerts/Festival.png",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "eleven",
                                    Image = "../../Content/images/index/Bohemi.jpg",
                                },

                                new Event()
                                {
                                    Name = "twelve",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            },
                        },

                        new Category()
                        {
                            //Id = 13,
                            Name = "Metal",
                            Image = "../../Content/images/concerts/Metal.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "tirdteen",
                                    Image = "../../Content/images/index/Bohemi.jpg",
                                },

                                new Event()
                                {
                                    Name = "fourteen",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            },
                        },
                        new Category()
                        {
                            //Id = 14,
                            Name = "Hip-Hop",
                            Image = "../../Content/images/concerts/Hip-Hop.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "fiveteen",
                                    Image = "../../Content/images/index/Bohemi.jpg",
                                },

                                new Event()
                                {
                                    Name = "sixteen",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            },
                        },
                        new Category()
                        {
                            //Id = 15,
                            Name = "Blues",
                            Image = "../../Content/images/concerts/Blues.jpg",

                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "seventeen",
                                    Image = "../../Content/images/index/Bohemi.jpg",
                                },

                                new Event()
                                {
                                    Name = "eightteen",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            },
                        }
                    }
                },

                new AllCategory()
                {
                    Id = 2,
                    Name = "Culture",

                    Categories = new List<Category>()
                    {
                        new Category()
                        {
                            //Id = 1,
                            Name = "Comedy",
                            Image = "../../Content/images/culture/Comedy.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-one",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },

                        new Category()
                        {
                            //Id = 1,
                            Name = "Theater",
                            Image = "../../Content/images/culture/Theatre.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },
                          new Category()
                        {
                            //Id = 1,
                            Name = "Ballet",
                            Image = "../../Content/images/culture/Balet.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },
                           new Category()
                        {
                            //Id = 1,
                            Name = "Opera",
                            Image = "../../Content/images/culture/Opera.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },
                            new Category()
                        {
                            //Id = 1,
                            Name = "Variety Show",
                            Image = "../../Content/images/culture/Variete.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },
                        new Category()
                        {
                            //Id = 1,
                            Name = "Dance",
                            Image = "../../Content/images/culture/Dance.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },
                              new Category()
                        {
                            //Id = 1,
                            Name = "Show",
                            Image = "../../Content/images/culture/Show.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },
                               new Category()
                        {
                            //Id = 1,
                            Name = "Chanson",
                            Image = "../../Content/images/culture/Shanson.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        }
                    }
                },
                new AllCategory()
                {
                    Id = 3,
                    Name = "Sport",

                    Categories = new List<Category>()
                    {
                        new Category()
                        {
                            //Id = 1,
                            Name = "Footbal",
                            Image = "../../Content/images/sport/Football.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-one",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },

                        new Category()
                        {
                            //Id = 1,
                            Name = "Tennis",
                            Image = "../../Content/images/sport/Tennis.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },
                          new Category()
                        {
                            //Id = 1,
                            Name = "Other sport events",
                            Image = "../../Content/images/sport/Drugi.png",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },
                        
                    }
                },
                new AllCategory()
                {
                    Id = 4,
                    Name = "Other Events",

                    Categories = new List<Category>()
                    {
                        new Category()
                        {
                            //Id = 1,
                            Name = "Exposition",
                            Image = "../../Content/images/others/izlojbi.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-one",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },

                        new Category()
                        {
                            //Id = 1,
                            Name = "Moovie",
                            Image = "../../Content/images/others/kino.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },
                          new Category()
                        {
                            //Id = 1,
                            Name = "Night club",
                            Image = "../../Content/images/others/night-club.jpg",


                            Events = new List<Event>()
                            {
                                new Event()
                                {
                                    Name = "twenty-two",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },

                                new Event()
                                {
                                    Name = "twenty-three",
                                    Image = "../../Content/images/index/Fabian.jpg",
                                },
                            }
                        },

                    }
                });







            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }
    }
}
