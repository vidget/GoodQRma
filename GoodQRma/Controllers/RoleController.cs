using System;
using System.Linq;
using System.Web.Mvc;

using GoodQRma.Models;
using Microsoft.AspNet.Identity.EntityFramework;


namespace GoodQRma.Controllers
{

     [Authorize]
    public class RoleController : Controller
    {
        ApplicationDbContext context;



        public RoleController()
        {
            context = new ApplicationDbContext();
            
        }



        /// <summary>
        /// Get All Roles
        /// </summary>
        /// <returns></returns>
        /// 

        [Authorize(Roles = "Admin")]
        public ActionResult Index()
        {
            var Roles = context.Roles.ToList();
            return View(Roles);



        }

        /// <summary>
        /// Create  a New role
        /// </summary>
        /// <returns></returns>
        /// 

        [Authorize(Roles = "Admin")]
        public ActionResult Create()
        {
            var Role = new IdentityRole();
            return View(Role);
        }

        /// <summary>
        /// Create a New Role
        /// </summary>
        /// <param name="Role"></param>
        /// <returns></returns>
        [HttpPost]
        [Authorize(Roles = "Admin")]
        public ActionResult Create(IdentityRole Role)
        {
            context.Roles.Add(Role);
            context.SaveChanges();
            return RedirectToAction("Index","_LayoutADMIN");
        }


    }
}