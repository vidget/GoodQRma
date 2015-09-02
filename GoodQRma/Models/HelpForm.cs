using System;
using System.Collections.Generic;
<<<<<<< HEAD
=======
using System.ComponentModel.DataAnnotations;
>>>>>>> vidget/master
using System.Linq;
using System.Web;

namespace GoodQRma.Models
{
    public class HelpForm
    {
<<<<<<< HEAD
        public string To { get; set; }
        public string From { get; set; }
        public string Subject { get; set; }
        public string Body { get; set; }
    }
}
=======
            public string To{ get; set; }
            public string From{ get; set; }
            //public string To { get; set; }
            public string Subject { get; set; }
            public string Body { get; set; }
        

        //[Required, Display(Name = "Your name")]
        //public string FromName { get; set; }
        //[Required, Display(Name = "Your email"), EmailAddress]
        //public string FromEmail { get; set; }
        //[Required]
        //public string Message { get; set; }
    }
}
    
>>>>>>> vidget/master
