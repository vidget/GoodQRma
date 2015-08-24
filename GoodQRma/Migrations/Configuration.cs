namespace GoodQRma.Migrations
{
    using GoodQRma.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<GoodQRma.DAL.goodQRmaContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "GoodQRma.DAL.goodQRmaContext";
        }

        protected override void Seed(GoodQRma.DAL.goodQRmaContext context)
        {
            var users = new List<User>
                {
                    new User{userID=1,profileName ="Greg",address1 = "22859 Beech", 
                        address2 ="",city="Dearborn",state="Michigan",zipCode="48124",country="USA",
                        phone ="313-516-1559", webURL1 = "www.yahoo.com", webURL2 = "www.google.com", webURL3 = "www.amazon.com", },

                    new User{userID=2,profileName ="Steve",address1 = "4752 Palmer", 
                        address2 ="",city="Dearborn",state="Michigan",zipCode="48126",country="USA",
                        phone ="313-555-1129", webURL1 = "www.ebay.com", webURL2 = "www.cnn.com", webURL3 = "www.craigslist.com", },


                     new User{userID=3,profileName ="Paul",address1 = "7324 St.Marys", 
                        address2 ="",city="Detroit",state="Michigan",zipCode="48128",country="USA",
                        phone ="313-555-2319", webURL1 = "www.time.com", webURL2 = "www.ebay.com", webURL3 = "www.clickondetroit.com", },

                    new User{userID=4,profileName ="Jimbo",address1 = "22859 Beech", 
                        address2 ="",city="Dearborn",state="Michigan",zipCode="48124",country="USA",
                        phone ="313-516-1459", webURL1 = "www.yahoo.com", webURL2 = "www.google.com", webURL3 = "www.amazon.com", },

                    new User{userID=5,profileName ="Sammy",address1 = "3453 Walwit", 
                        address2 ="",city="Dearborn Heights",state="Michigan",zipCode="48126",country="USA",
                        phone ="313-555-1129", webURL1 = "www.ebay.com", webURL2 = "www.cnn.com", webURL3 = "www.craigslist.com", },


                     new User{userID=6,profileName ="Brandon",address1 = "7324 St.Marys", 
                        address2 ="",city="St. Clair Shores",state="Michigan",zipCode="48080",country="USA",
                        phone ="313-555-9339", webURL1 = "www.time.com", webURL2 = "www.ebay.com", webURL3 = "www.clickondetroit.com", }

                };


            users.ForEach(p => context.Users.AddOrUpdate(s => s.userID, p));
            context.SaveChanges();

            // EVENT MODEL

            var events = new List<Event>
                {
                    new Event
                    {
                        eventID=1,
                        image=0,
                        userID=1,
                        name="Rouge River Clean-Up",
                        description ="Come help us clean up the old Rouge River, volunteers will be helping to remove old shopping carts and garbage from the river. Dress warm and bring extra dry clothes", 
                        eventDate=DateTime.Now, 
                        eventTime=DateTime.Now, 
                        eventType="Clean Up",
                        address1 ="22051 Cherry Hill Street",
                        address2="",city="Dearborn",
                        state ="Michigan",
                        zipCode="48124",
                        country="USA",
                        contact="Sally Jones",
                        phone="313-792-9900",
                        gpsLong=-83.248262,
                        gpsLat=42.312365,
                        eventURL="http://www.therouge.org/"
                    },

                    new Event
                    {
                        eventID=2,
                        image=0,
                        userID=1,
                        name="Summer Stevens Clean Up Parade",
                        description ="Were working to make Dearborn a cleaner place to live. We organize clean up groups on the day to help pick up trash at Summer Stevens park", 
                        eventDate=DateTime.Now, 
                        eventTime=DateTime.Now, 
                        eventType="Clean Up",
                        address1 =" 2600 Stephens St",
                        address2="",city="Dearborn",
                        state ="Michigan",
                        zipCode="48124",
                        country="USA",
                        contact="Mike Allen",
                        phone="313-555-4567",
                        gpsLong= -83.254373,
                        gpsLat= 42.29628, 
                        eventURL="http://www.cityofdearborn.org/community/recreation-parks/outdoor-pools"
                    },

                                        
                    new Event
                    {   
                        eventID=3,
                        image=0,
                        userID=2,
                        name="Detroit Rescue Misson",
                        description ="We need help at our soup kitchen feeding the hungry", 
                        eventDate=DateTime.Now, 
                        eventTime=DateTime.Now, 
                        eventType="Homeless",
                        address1 =" 150 Stimson St",
                        address2="",city="Detroit",
                        state ="Michigan",
                        zipCode="48201",
                        country="USA",
                        contact="Mike Allen",
                        phone="(313) 993-4700",
                        gpsLong= -83.05996,
                        gpsLat= 42.345477,
                        eventURL="http://drmm.org/"
                    }

                };


            events.ForEach(p => context.Events.AddOrUpdate(s => s.eventID, p));


            context.SaveChanges();

            foreach (var ev in context.Events)
            {
                foreach (var user in context.Users)
                {
                    ev.Users.Add(user);
                }
            }

            context.SaveChanges();
        }
    }
}
