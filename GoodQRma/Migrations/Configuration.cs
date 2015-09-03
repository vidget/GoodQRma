namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GoodQRma.Models;
    using System.Collections.Generic;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity;

    internal sealed class Configuration : DbMigrationsConfiguration<GoodQRma.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GoodQRma.Models.ApplicationDbContext context)
        {


            //Creates a MEMBER Role  and puts it in the ASPNETROLES Table
            if (!context.Roles.Any(r => r.Name == "Member"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Member" };

                manager.Create(role);
            }


            //Creates a ADMIN Role  and puts it in the ASPNETROLES Table
            if (!context.Roles.Any(r => r.Name == "Admin"))
            {
                var store = new RoleStore<IdentityRole>(context);
                var manager = new RoleManager<IdentityRole>(store);
                var role = new IdentityRole { Name = "Admin" };

                manager.Create(role);
            }



            //Creates a USER, the PAGE ADMIN with ADMIN ROLE
            var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));
            var PasswordHash = new PasswordHasher();
            if (!context.Users.Any(u => u.UserName == "admin@goodqrma.com"))
            {
                var user = new ApplicationUser
                {
                    UserName = "admin@goodqrma.com",
                    Email = "goodqrma@gmail.com",
                    PasswordHash = PasswordHash.HashPassword("Admin@1"),
                     Name = "GoodQRma Site Admin",
                    Address = "1570 Woodward Ave ",
                    City = "Detroit",
                    State = "Michigan",
                    ZipCode = "48226",
                    Country = "United States",
                };

                
                UserManager.Create(user);
                UserManager.AddToRole(user.Id,"Admin");
            }

            if (!context.Users.Any(u => u.UserName == "moe@3stooges.com"))
            {
                var user = new ApplicationUser
                {
                    
                    UserName = "moe@3stooges.com",
                    Email = "moe@3stooges.com",
                    PasswordHash = PasswordHash.HashPassword("Stooge@1"),
                    Name = "Moe Howard",
                    Address = "452 Mill Road",
                    City = "Northville",
                    State = "Michigan",
                    ZipCode = "48167",
                    Country = "United States",
                  };
                UserManager.Create(user);
                UserManager.AddToRole(user.Id, "Member");
            }

            if (!context.Users.Any(u => u.UserName == "larry@3stooges.com"))
            {
                var user = new ApplicationUser
                {
                    UserName = "larry@3stooges.com",
                    Email = "larry@3stooges.com",
                    PasswordHash = PasswordHash.HashPassword("Stooge@1"),
                    Name = "Larry Howard",
                    Address = "504 Catherine Street",
                    City = "Ashtabula",
                    State = "Ohio",
                    ZipCode = "44004",
                    Country = "United States",
                };
                UserManager.Create(user);
                UserManager.AddToRole(user.Id, "Member");
            }

            if (!context.Users.Any(u => u.UserName == "curly@3stooges.com"))
            {
                var user = new ApplicationUser
                {
                    UserName = "curly@3stooges.com",
                    Email = "curly@3stooges.com",
                    PasswordHash = PasswordHash.HashPassword("Stooge@1"),
                    Name = "Curly Howard",
                    Address = "305 Hudson Street ",
                    City = "Encino",
                    State = "California",
                    ZipCode = "91316",
                    Country = "United States",
                };
                UserManager.Create(user);
                UserManager.AddToRole(user.Id, "Member");
            }

            if (!context.Users.Any(u => u.UserName == "shemp@3stooges.com"))
            {
                var user = new ApplicationUser
                {
                    UserName = "shemp@3stooges.com",
                    Email = "shemp@3stooges.com",
                    PasswordHash = PasswordHash.HashPassword("Stooge@1"),
                    Name = "Shemp Howard",
                    Address = "368 Primrose Lane ",
                    City = "Detroit",
                    State = "Michigan",
                    ZipCode = "48205",
                    Country = "United States",
                };
                UserManager.Create(user);
                UserManager.AddToRole(user.Id, "Member");
            }


          

          



            var events = new List<Event>
                {
                    new Event
                    {
                        eventID=1,
                        image=0,
                        userID="1",   
                        name="Rouge River Clean-Up",
                        description ="Come help us clean up the old Rouge River, volunteers will be helping to remove old shopping carts and garbage from the river. Dress warm and bring extra dry clothes", 
                        eventDate=DateTime.Now, 
                        eventTime=DateTime.Now, 
                        eventType="Clean Up",
                        address1 ="22051 Cherry Hill Street",
                        state ="Michigan",
                        zipCode="48124",
                        country="USA",
                        contact="Sally Jones",
                        phone="313-792-9900",
                        eventURL="http://www.therouge.org/"
                    }

            //        new Event
            //        {
            //            eventID=2,
            //            //image=0,
            //            userID="1",
            //            name="Summer Stevens Clean Up Parade",
            //            description ="Were working to make Dearborn a cleaner place to live. We organize clean up groups on the day to help pick up trash at Summer Stevens park", 
            //            eventDate=DateTime.Now, 
            //            eventTime=DateTime.Now, 
            //            eventType="Clean Up",
            //            address1 ="2600 Stephens St",
            //            state ="Michigan",
            //            zipCode="48124",
            //            country="USA",
            //            contact="Mike Allen",
            //            phone="313-555-4567",
            //            eventURL="http://www.cityofdearborn.org/community/recreation-parks/outdoor-pools"
            //        },

                                        
            //        new Event
            //        {   
            //            eventID=3,
            //            //image=0,
            //            userID="2",
            //            name="Detroit Rescue Misson",
            //            description ="We need help at our soup kitchen feeding the hungry", 
            //            eventDate=DateTime.Now, 
            //            eventTime=DateTime.Now, 
            //            eventType="Homeless",
            //            address1 ="150 Stimson St",
            //            city="Detroit",
            //            state ="Michigan",
            //            zipCode="48201",
            //            country="USA",
            //            contact="Mike Allen",
            //            phone="(313) 993-4700",
            //            eventURL="http://drmm.org/"
            //        }

            //    };


            //events.ForEach(p => context.Events.AddOrUpdate(s => s.eventID, p));


            //context.SaveChanges();
        }
    }
}
