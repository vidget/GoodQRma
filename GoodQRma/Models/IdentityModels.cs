using System;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace GoodQRma.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
  
    public class ApplicationUser : IdentityUser
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
        public virtual string webURL1 { get; set; }
        public virtual string webURL2 { get; set; }
        public virtual string webURL3 { get; set; }

        public virtual ICollection<File> Files { get; set; }
        public virtual ICollection<Event> Events { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public System.Data.Entity.DbSet<GoodQRma.Models.ApplicationUser> ApplicationUsers { get; set; }
    }
}