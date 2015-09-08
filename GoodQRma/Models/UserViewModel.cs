using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace GoodQRma.Models
{

    public class GroupedUserViewModel
    {
        public List<UserViewModel> Members { get; set; }
        public List<UserViewModel> Admins { get; set; }
    }

    public class UserViewModel
    {
        public int UserViewModelId { get; set; }
        public string Username { get; set; }
        public string Roles { get; set; }
    }
}