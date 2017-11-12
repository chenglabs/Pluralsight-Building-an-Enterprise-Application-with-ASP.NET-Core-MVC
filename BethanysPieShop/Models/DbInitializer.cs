using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BethanysPieShop.Models
{
    public static class DbInitializer
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<AppDbContext>>()))
            {
                
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(Categories.Select(c => c.Value));
                }

                if (!context.Pies.Any())
                {
                    context.AddRange
                    (
                        new Pie
                        {
                            Name = "Apple Pie Small",
                            Price = 12.95M,
                            ShortDescription = "Our famous apple pies!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Fruit pies"],
                            ImageUrl = "/Images/applepie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            ImageThumbnailUrl =
                                "/Images/applepiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Blueberry Cheese Cake Small",
                            Price = 18.95M,
                            ShortDescription = "You'll love it!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Cheese cakes"],
                            ImageUrl =
                                "/Images/blueberrycheesecake.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/blueberrycheesecakesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Cheese Cake Small",
                            Price = 18.95M,
                            ShortDescription = "Plain cheese cake. Plain pleasure.",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Cheese cakes"],
                            ImageUrl = "/Images/cheesecake.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/cheesecakesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Cherry Pie Small",
                            Price = 15.95M,
                            ShortDescription = "A summer classic!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Fruit pies"],
                            ImageUrl = "/Images/cherrypie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/cherrypiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Christmas Apple Pie Small",
                            Price = 13.95M,
                            ShortDescription = "Happy holidays with this pie!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Seasonal pies"],
                            ImageUrl =
                                "/Images/christmasapplepie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/christmasapplepiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Cranberry Pie Small",
                            Price = 17.95M,
                            ShortDescription = "A Christmas favorite",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Seasonal pies"],
                            ImageUrl = "/Images/cranberrypie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/cranberrypiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Peach Pie Small",
                            Price = 15.95M,
                            ShortDescription = "Sweet as peach",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Fruit pies"],
                            ImageUrl = "/Images/peachpie.jpg",
                            InStock = false,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/peachpiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Pumpkin Pie Small",
                            Price = 12.95M,
                            ShortDescription = "Our Halloween favorite",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Seasonal pies"],
                            ImageUrl = "/Images/pumpkinpie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            ImageThumbnailUrl =
                                "/Images/pumpkinpiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Rhubarb Pie Small",
                            Price = 15.95M,
                            ShortDescription = "My God, so sweet!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Fruit pies"],
                            ImageUrl = "/Images/rhubarbpie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            ImageThumbnailUrl =
                                "/Images/rhubarbpiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Strawberry Pie Small",
                            Price = 15.95M,
                            ShortDescription = "Our delicious strawberry pie!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Fruit pies"],
                            ImageUrl = "/Images/strawberrypie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/strawberrypiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Strawberry Cheese Cake Small",
                            Price = 18.95M,
                            ShortDescription = "You'll love it!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Cheese cakes"],
                            ImageUrl =
                                "/Images/strawberrycheesecake.jpg",
                            InStock = false,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/strawberrycheesecakesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Apple Pie Big",
                            Price = 12.95M * 2,
                            ShortDescription = "Our famous apple pies!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Fruit pies"],
                            ImageUrl = "/Images/applepie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            ImageThumbnailUrl =
                                "/Images/applepiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Blueberry Cheese Cake Big",
                            Price = 18.95M * 2,
                            ShortDescription = "You'll love it!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Cheese cakes"],
                            ImageUrl =
                                "/Images/blueberrycheesecake.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/blueberrycheesecakesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Cheese Cake Big",
                            Price = 18.95M * 2,
                            ShortDescription = "Plain cheese cake. Plain pleasure.",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Cheese cakes"],
                            ImageUrl = "/Images/cheesecake.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/cheesecakesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Cherry Pie Big",
                            Price = 15.95M * 2,
                            ShortDescription = "A summer classic!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Fruit pies"],
                            ImageUrl = "/Images/cherrypie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/cherrypiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Christmas Apple Pie Big",
                            Price = 13.95M * 2,
                            ShortDescription = "Happy holidays with this pie!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Seasonal pies"],
                            ImageUrl =
                                "/Images/christmasapplepie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/christmasapplepiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Cranberry Pie Big",
                            Price = 17.95M * 2,
                            ShortDescription = "A Christmas favorite",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Seasonal pies"],
                            ImageUrl = "/Images/cranberrypie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/cranberrypiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Peach Pie Big",
                            Price = 15.95M * 2,
                            ShortDescription = "Sweet as peach",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Fruit pies"],
                            ImageUrl = "/Images/peachpie.jpg",
                            InStock = false,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/peachpiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Pumpkin Pie Big",
                            Price = 12.95M * 2,
                            ShortDescription = "Our Halloween favorite",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Seasonal pies"],
                            ImageUrl = "/Images/pumpkinpie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            ImageThumbnailUrl =
                                "/Images/pumpkinpiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Rhubarb Pie Big",
                            Price = 15.95M * 2,
                            ShortDescription = "My God, so sweet!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Fruit pies"],
                            ImageUrl = "/Images/rhubarbpie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = true,
                            ImageThumbnailUrl =
                                "/Images/rhubarbpiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Strawberry Pie Big",
                            Price = 15.95M * 2,
                            ShortDescription = "Our delicious strawberry pie!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Fruit pies"],
                            ImageUrl = "/Images/strawberrypie.jpg",
                            InStock = true,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/strawberrypiesmall.jpg",
                            AllergyInformation = ""
                        },
                        new Pie
                        {
                            Name = "Strawberry Cheese Cake Big",
                            Price = 18.95M * 2,
                            ShortDescription = "You'll love it!",
                            LongDescription =
                                "Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake pie chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon pie muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart pie cake danish lemon drops. Brownie cupcake dragée gummies.",
                            Category = Categories["Cheese cakes"],
                            ImageUrl =
                                "/Images/strawberrycheesecake.jpg",
                            InStock = false,
                            IsPieOfTheWeek = false,
                            ImageThumbnailUrl =
                                "/Images/strawberrycheesecakesmall.jpg",
                            AllergyInformation = ""
                        }
                    );
                }

                context.SaveChanges();
            }
        }

        private static Dictionary<string, Category> categories;
        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Fruit pies" },
                        new Category { CategoryName = "Cheese cakes" },
                        new Category { CategoryName = "Seasonal pies" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}
