using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using GoodQRma.Models;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace GoodQRma.Models
{
    public class Event
    {
         
            //[StringLength(10, ErrorMessage = "Max 10 digits")]
            [Display(Name = "Event ID")]
            public virtual int? eventID { get; set; }

         
            //[StringLength(10, ErrorMessage = "Max10 digits")]
            [Display(Name = "UserID")]
            public virtual string userID { get; set; }

            //[Required]
            [Display(Name = "Image")]
            public virtual byte? image { get; set; }


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
            [Display(Name = "Event Date")]
            [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
            [DataType(DataType.Date)]
            public virtual DateTime eventDate { get; set; }


            //[Required]
            [DataType(DataType.Time)]
            [DisplayFormat(DataFormatString = "{0:T}")]
            [Display(Name = "Event Time")]
            public virtual DateTime eventTime { get; set; }

           // [Required]
            [Display(Name = "Volunteers Needed")]
            public virtual int? numVolunteersNeeded { get; set; }

            //[Required]
            [StringLength(50, ErrorMessage = "Not a valid Address")]
            [Display(Name = "Address")]
            public virtual string address1 { get; set; }

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

            public virtual string eventURL { get; set; }

            //[Required]
            //[Display(Name = "List of Users")]
            public virtual ICollection<ApplicationUser> Users { get; set; }

        public string getFullAddress()
            {
                string fullAddress = address1 + ", " + city + ", " + state + ", " + zipCode;
                return fullAddress;
            }
        public virtual ICollection<File> Files { get; set; }

        }
    }






   