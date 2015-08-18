using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodQRma.Models;

namespace GoodQRma.Models
{
    public class User
    {

        public int userID { get; set; }
        public string profileName { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string country { get; set; }
        public string phone { get; set; }
        public  string email { get; set; }
        public string webURL1 { get; set; }
        public string webURL2 { get; set; }
        public string webURL3 { get; set; }


        public User()
        {
            userID = 0;
            profileName = "";
            address1 = "";
            address2 = "";
            city = "";
            state = "";
            zipCode = "";
            country ="";
            phone ="";
            email ="";
            webURL1="";
            webURL2="";
            webURL3="";
         }



    }
}