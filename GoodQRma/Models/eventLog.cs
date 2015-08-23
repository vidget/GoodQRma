using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodQRma.Models
{
    public class eventLog
    {
        public virtual int eventLogID { get; set; }
        public virtual int userID { get; set; }
        public virtual int eventID { get; set; }


        //public eventLog()
        //{
        //    eventLogID = 0;
        //    userID = 0;
        //    eventID = 0;


        //}

    }
}