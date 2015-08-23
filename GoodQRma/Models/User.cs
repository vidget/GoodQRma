using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodQRma.Models;

namespace GoodQRma.Models
{
    public class User
    {
        public virtual byte profilePic { get; set; } 
        public virtual int userID { get; set; }
        public virtual string profileName { get; set; }
        public virtual string address1 { get; set; }
        public virtual string address2 { get; set; }
        public virtual string city { get; set; }
        public virtual string state { get; set; }
        public virtual string zipCode { get; set; }
        public virtual string country { get; set; }
        public virtual string phone { get; set; }
        public virtual string email { get; set; }
        public virtual string webURL1 { get; set; }
        public virtual string webURL2 { get; set; }
        public virtual string webURL3 { get; set; }


        //public User()
        //{
        //    userID = 0;
        //    profileName = "";
        //    address1 = "";
        //    address2 = "";
        //    city = "";
        //    state = "";
        //    zipCode = "";
        //    country ="";
        //    phone ="";
        //    email ="";
        //    webURL1="";
        //    webURL2="";
        //    webURL3="";
        // }



    }
}