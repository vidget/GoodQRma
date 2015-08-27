using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodQRma.Models;
using System.ComponentModel.DataAnnotations;

namespace GoodQRma.Models
{
    public class Event
    {
         
            //[StringLength(10, ErrorMessage = "Max 10 digits")]
            [Display(Name = "Event ID")]
            public virtual int eventID { get; set; }

         
            //[StringLength(10, ErrorMessage = "Max10 digits")]
            [Display(Name = "UserID")]
            public virtual int userID { get; set; }

            //[Required]
            //[Display(Name = "Image")]
            //[RegularExpression ("(.*?)\.(jpg|bmp|gif|png|jpeg)$")]

           // [Required]
            [Display(Name = "Image")]
            public virtual byte image { get; set; }


            //[Required]
            //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
            [Display(Name = "EventName")]
            public virtual string name { get; set; }

            //[Required]
            [StringLength(250, ErrorMessage = "Event description  cannot be longer than 250 characters.")]
            [Display(Name = "Event Description")]
            public virtual string description { get; set; }

            //[Required]
            //[RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$")]
            [Display(Name = "Type of Event")]
            public virtual string eventType { get; set; }

           // [Required]
            //[Display(Name = "Event Date")]
           // [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            [DataType(DataType.Date)]
            public virtual DateTime eventDate { get; set; }


            //[Required]
            //[DataType(DataType.Time)]
            //[DisplayFormat(DataFormatString = "{0:T}")]
            [Display(Name = "Event Time")]
            public virtual DateTime eventTime { get; set; }

           // [Required]
            [Display(Name = "Number of Volunteers Needed")]
            public virtual int numVolunteersNeeded { get; set; }

            //[Required]
            [StringLength(50, ErrorMessage = "Not a valid Address")]
            [Display(Name = "Address")]
            public virtual string address1 { get; set; }

            //[Required]
            [StringLength(50, ErrorMessage = "Not a valid Address")]
            [Display(Name = "Address")]
            public virtual string address2 { get; set; }

            //[Required]
            [StringLength(25, ErrorMessage = "Not a valid City")]
            [Display(Name = "City")]
            public virtual string city { get; set; }

            //[Required]
            [StringLength(25, ErrorMessage = "Not a valid State")]
            [Display(Name = "State")]
            public virtual string state { get; set; }


            //[Required]
            //[StringLength(9, ErrorMessage = "Not a valid ZipCode")]
            [MaxLength(9)]
            [Display(Name = "ZipCode")]
            public virtual string zipCode { get; set; }

            //[Required]
            //[StringLength(15, ErrorMessage = "Not a valid Country Name")]
            [MaxLength(15)]
            [Display(Name = "Country")]
            public virtual string country { get; set; }

            //[Required]
            //[StringLength(25, ErrorMessage = "Give your first Name alone ")]
        
            [MaxLength(25)]
            [Display(Name = "ContactName")]
            public virtual string contact { get; set; }


            //[Required]
            //[StringLength(15, ErrorMessage = "Not a valid Phone number")]
            [Phone]
            [Display(Name = "PhoneNumber")]
            public virtual string phone { get; set; }

            //[Required]
            [Display(Name = "GPSLongitude")]
            public virtual double gpsLong { get; set; }

            //[Required]
            [Display(Name = "GPSLatitude")]
            public virtual double gpsLat { get; set; }


            public virtual string eventURL { get; set; }

            //[Required]
            //[Display(Name = "List of Users")]
            public virtual ICollection<User> Users { get; set; }
        }
    }
        //public virtual int eventID { get; set; }
        //public virtual int userID { get; set; }
        //public virtual byte image { get; set; }
        //public virtual string name { get; set; }
        //public virtual string description { get; set; }
        //public virtual string eventType { get; set; }
        //public virtual DateTime eventDate { get; set; }
        //public virtual DateTime eventTime { get; set; }
        //public virtual int numVolunteersNeeded { get; set; }

        //public virtual string address1 { get; set; }
        //public virtual string address2 { get; set; }

        //public virtual string city { get; set; }
        //public virtual string state { get; set; }
        //public virtual string zipCode { get; set; }
        //public virtual string country { get; set; }
        //public virtual string contact { get; set; }
        //public virtual string phone { get; set; }

        //public virtual double gpsLong { get; set; }
        //public virtual double gpsLat { get; set; }

        //public virtual string eventURL { get; set; }

        //public virtual ICollection<User> Users { get; set; }




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






   