using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodQRma.Models;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNet.Identity;

namespace GoodQRma.Models
{
    public class User
    {
       // [Required]
        [Display(Name = "ProfilePicture")]
        public virtual byte profilePic { get; set; }


        
        //[StringLength(10, ErrorMessage = "Max 10 digits")]
        [Display(Name = "UserId")]
        public virtual int userID { get; set; }

        public virtual string userIDLogin { get; set; }

        //[Required]
        [Display(Name = "ProfileName")]
        public virtual string profileName { get; set; }

        //[Required]
        //[StringLength(25)]
        //[MaxLength(25)]
        [Display(Name = "Address")]
        public virtual string address1 { get; set; }

        //[Required]
        //[StringLength(25)]
        //[MaxLength(25)]
        [Display(Name = "Address")]
        public virtual string address2 { get; set; }

        //[Required]
        //[StringLength(25)]
       // [MaxLength(25)]
        [Display(Name = "City")]
        public virtual string city { get; set; }
        [Required]

        [StringLength(15)]
        [Display(Name = "State")]
        public virtual string state { get; set; }
      

       
        [MaxLength(10)]
        [Display(Name = "ZipCode")]
        public virtual string zipCode { get; set; }

        
        [MaxLength(15)]
        [Display(Name = "Country")]
        public virtual string country { get; set; }



        [MaxLength(15)]
        [Display(Name = "Phone")]
        public virtual string phone { get; set; }

        //[RegularExpression("(?<name>.*?)<(?<email>.*?)>")]
        //[EmailAddress]
        //[Required]
        [Display(Name = "Email_id")]
        public virtual string email { get; set; }

        
        //[Url]
       // [Required] 
       // [Display (Name ="URL")]
        public virtual string webURL1 { get; set; }

        public virtual string webURL2 { get; set; }
        public virtual string webURL3 { get; set; }





        public int getLoggedInUserID(string logName, string logEmail)
        {


            if (logName == logEmail)
                return userID;
            else
                return 0;
        }





        public virtual ICollection<File> Files { get; set; }
       public virtual ICollection<Event> Events { get; set; }
    }




}
       



   