using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodQRma.Models;

namespace GoodQRma.Models
{
    public class Event
    {

        public virtual int eventID { get; set; }
        public virtual int userID { get; set; }
        public virtual byte image { get; set; }
        public virtual string name { get; set; }
        public virtual string description { get; set; }
        public virtual string eventType { get; set; }
        public virtual DateTime eventDate { get; set; }
        public virtual DateTime eventTime { get; set; }
        public virtual int numVolunteersNeeded { get; set; }

        public virtual string address1 { get; set; }
        public virtual string address2 { get; set; }

        public virtual string city { get; set; }
        public virtual string state { get; set; }
        public virtual string zipCode { get; set; }
        public virtual string country { get; set; }
        public virtual string contact { get; set; }
        public virtual string phone { get; set; }

        public virtual double gpsLong { get; set; }
        public virtual double gpsLat { get; set; }

        public virtual string eventURL { get; set; }




        //public Event()
        //{
        //    eventID = 0;
        //    userID = 0;
        //    image = 0;
        //    name = "";
        //    description = "";
        //    eventDate = DateTime.Now;
        //    eventTime = DateTime.Now;
        //    eventType = "";
        //    address1 = "";
        //    address2 = "";
        //    city = "";
        //    state = "";
        //    zipCode = "";
        //    country = "";
        //    contact = "";
        //    phone = "";
        //    gpsLong = 0.00F;
        //    gpsLat = 0.00F;
        //    eventURL = "";
        //}






    }
}