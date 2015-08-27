using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GoodQRma.DAL;
using GoodQRma.Models;
using GoodQRma.Controllers;

namespace GoodQRma.Controllers
{
    public class UserController : Controller
    {
        private goodQRmaContext db = new goodQRmaContext();


        // GET: User
        public ActionResult Index(int? id)
        {
            User user = db.Users.Include(s => s.Files).SingleOrDefault(s => s.userID == id);





            return View(db.Users.ToList());
        }

        // GET: User/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            User user = db.Users.Include(s => s.Files).SingleOrDefault(s => s.userID == id);
            //User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: User/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "userID,profilePic,profileName,address1,address2,city,state,zipCode,country,phone,email,webURL1,webURL2,webURL3")] User user, HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {

                if (upload != null && upload.ContentLength > 0)
                {
                    var avatar = new File
                    {
                        FileName = System.IO.Path.GetFileName(upload.FileName),
                        FileType = FileType.Avatar,
                        ContentType = upload.ContentType
                    };
                    using (var reader = new System.IO.BinaryReader(upload.InputStream))
                    {
                        avatar.Content = reader.ReadBytes(upload.ContentLength);
                    }
                    user.Files = new List<File> { avatar };
                }



                db.Users.Add(user);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(user);
        }








        // GET: User/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            
            User user = db.Users.Include(s => s.Files).SingleOrDefault(s => s.userID == id);

            //User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }


        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "userID,profilePic,profileName,address1,address2,city,state,zipCode,country,phone,email,webURL1,webURL2,webURL3")] User user,HttpPostedFileBase upload)
        {
            if (ModelState.IsValid)
            {
                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(user);
        }





        // POST: User/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int? id,[Bind(Include = "userID,profilePic,profileName,address1,address2,city,state,zipCode,country,phone,email,webURL1,webURL2,webURL3")] User user, HttpPostedFileBase upload)
        //{
        //    var userToUpdate = db.Users.Find(id);

        //    if (ModelState.IsValid)
        //    {
                                

        //        if (upload != null && upload.ContentLength > 0)
        //                 {

        //                     Checks to see if there is currently a picture in the file if there is it removes it from the database before putting the new one in.
        //                     if (userToUpdate.Files.Any(f => f.FileType == FileType.Avatar))
        //                     {
        //                         removes the picture from the database
        //                         db.Files.Remove(user.Files.First(f => f.FileType == FileType.Avatar));
        //                     }

        //                     creates a new image
        //                     var avatar = new File
        //                     {
        //                         FileName = System.IO.Path.GetFileName(upload.FileName),
        //                         FileType = FileType.Avatar,
        //                         ContentType = upload.ContentType
        //                     };
        //                     converts it to bytes to store in the database as byte
        //                     using (var reader = new System.IO.BinaryReader(upload.InputStream))
        //                     {
        //                         avatar.Content = reader.ReadBytes(upload.ContentLength);
        //                     }
        //                     userToUpdate.Files = new List<File> { avatar };
        //                  }

                 
        //        db.Entry(userToUpdate).State = EntityState.Modified;
        //        db.SaveChanges();
        //           return RedirectToAction("Index");
        //    }
        //    return View(userToUpdate);
        //}

        

















        //// POST: User/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost, ActionName("Edit")]
        //[ValidateAntiForgeryToken]
        //public ActionResult Edit(int? id,[Bind(Include = "userID,profilePic,profileName,address1,address2,city,state,zipCode,country,phone,email,webURL1,webURL2,webURL3")] User user,HttpPostedFileBase upload)
        //{
             
              

        //    if (id == 0)
        //    {
        //        return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
        //    }
        //    var userToUpdate = db.Users.Find(id);



        //    if (ModelState.IsValid)
        //    {
                
        //        //Checks to see make sure the upload has something
        //        if (upload != null && upload.ContentLength > 0)
        //        {

        //            //Checks to see if there is currently a picture in the file if there is it removes it from the database before putting the new one in.
        //            if (userToUpdate.Files.Any(f => f.FileType == FileType.Avatar))
        //            {
        //                //removes the picture from the database
        //                db.Files.Remove(userToUpdate.Files.First(f => f.FileType == FileType.Avatar));
        //            }

        //            //creates a new image
        //            var avatar = new File
        //            {
        //                FileName = System.IO.Path.GetFileName(upload.FileName),
        //                FileType = FileType.Avatar,
        //                ContentType = upload.ContentType
        //            };
        //            //converts it to bytes to store in the database as byte
        //            using (var reader = new System.IO.BinaryReader(upload.InputStream))
        //            {
        //                avatar.Content = reader.ReadBytes(upload.ContentLength);
        //            }
        //            userToUpdate.Files = new List<File> { avatar };
        //        }

        //        //db.Users(userToUpdate).State = EntityState.Modified;

                 
        //        db.Entry(userT).State = EntityState.Modified;
        //        db.SaveChanges();
                

        //        return RedirectToAction("Index");
        //    }

        //    //return View(user);
        //    return View(userToUpdate);
        //}


        
      
        // GET: User/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            User user = db.Users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: User/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            User user = db.Users.Find(id);
            db.Users.Remove(user);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
