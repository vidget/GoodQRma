using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodQRma.Models;

namespace GoodQRma.Models
{
    public class Event
    {

        public int eventID { get; set; }
        public int userID { get; set; }
        public byte image { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string eventType { get; set; }
        public DateTime eventDate { get; set; }
        public DateTime eventTime { get; set; }

        public string address1 { get; set; }
        public string address2 { get; set; }

        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string country { get; set; }
        public string contact { get; set; }
        public string phone { get; set; }

        public double gpsLong { get; set; }
        public double gpsLat { get; set; }

        public string eventURL { get; set; }

        
        

        public Event()
        {
            eventID = 0;
            userID = 0;
            image = 0;
            name = "";
            description = "";
            eventDate = DateTime.Now;
            eventTime = DateTime.Now;
            eventType = "";
            address1 = "";
            address2 = "";
            city = "";
            state = "";
            zipCode = "";
            country = "";
            contact = "";
            phone = "";
            gpsLong = 0.00F;
            gpsLat = 0.00F;
            eventURL = "";
         }






    }
}