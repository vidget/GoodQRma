namespace GoodQRma.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using GoodQRma.Models;
    using System.Collections.Generic;

    internal sealed class Configuration : DbMigrationsConfiguration<GoodQRma.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(GoodQRma.Models.ApplicationDbContext context)
        {
            //var events = new List<Event>
            //    {
            //        new Event
            //        {
            //            eventID=1,
            //            //image=0,
            //            userID="1",   
            //            name="Rouge River Clean-Up",
            //            description ="Come help us clean up the old Rouge River, volunteers will be helping to remove old shopping carts and garbage from the river. Dress warm and bring extra dry clothes", 
            //            eventDate=DateTime.Now, 
            //            eventTime=DateTime.Now, 
            //            eventType="Clean Up",
            //            address1 ="22051 Cherry Hill Street",
            //            state ="Michigan",
            //            zipCode="48124",
            //            country="USA",
            //            contact="Sally Jones",
            //            phone="313-792-9900",
            //            eventURL="http://www.therouge.org/"
            //        },

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
