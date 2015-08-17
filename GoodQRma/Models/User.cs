using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodQRma.Models
{
    public class User
    {

        private int userID { get; set; }
        private string profileName { get; set; }
        private string address1 { get; set; }
        private string address2 { get; set; }
        private string city { get; set; }
        private string state { get; set; }
        private string zipCode { get; set; }
        private string country { get; set; }
        private string phone { get; set; }
        private  string email { get; set; }
        private string webURL1 { get; set; }
        private string webURL2 { get; set; }
        private string webURL3 { get; set; }


        public User()
        {
            profileName = "";
            address1 ="";
            address2 ="";
            city ="";
            state ="";
            zipCode ="";
            country ="";
            phone ="";
            email ="";
            webURL1="";
            webURL2="";
            webURL3="";
         }



    }
}