using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using DatabaseAccess;

namespace Cse_Just_Web_App.Controllers
{
    public class usersController : Controller
    {
        private csejustEntities db = new csejustEntities();

        // GET: users
        public ActionResult Index()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["last_name"])))
            {
                return RedirectToAction("Login", "Home");
            }
            var users = db.users.Include(u => u.usertype);
            return View(users.ToList());
        }

        // GET: users/Details/5
        public ActionResult Details(int? id)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["last_name"])))
            {
                return RedirectToAction("Login", "Home");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // GET: users/Create
        public ActionResult Create()
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["last_name"])))
            {
                return RedirectToAction("Login", "Home");
            }
            ViewBag.usertype_id = new SelectList(db.usertypes, "usertype_id", "usertype_name");
            return View();
        }

        // POST: users/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(user user)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["last_name"])))
            {
                return RedirectToAction("Login", "Home");
            }
            int userid = Convert.ToInt32(Convert.ToString(Session["user_id"]));
            user.user_id = userid;
            user.profile_pic = "/Content/UserPhoto";
            if (ModelState.IsValid)
            {
                db.users.Add(user);
                db.SaveChanges();
                if (user.PhotoFile != null)
                {
                    var folder = "/Content/UserPhoto";
                    var file = string.Format("{0}.png", user.user_id);
                    var response = FileHelper.UploadFile.UploadPhoto(user.PhotoFile, folder, file);
                    if (response)
                    {
                        var pic = string.Format("{0}/{1}", folder, file);
                        user.profile_pic = pic;
                        db.Entry(user).State = EntityState.Modified;
                        db.SaveChanges();
                    }
                }
                return RedirectToAction("Index");
            }

            ViewBag.usertype_id = new SelectList(db.usertypes, "usertype_id", "usertype_name", user.usertype_id);
            return View(user);
        }

        // GET: users/Edit/5
        public ActionResult Edit(int? id)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["last_name"])))
            {
                return RedirectToAction("Login", "Home");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            ViewBag.usertype_id = new SelectList(db.usertypes, "usertype_id", "usertype_name", user.usertype_id);
            return View(user);
        }

        // POST: users/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(user user)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["last_name"])))
            {
                return RedirectToAction("Login", "Home");
            }
            int userid = Convert.ToInt32(Convert.ToString(Session["user_id"]));
            user.user_id = userid;
            user.profile_pic = "/Content/UserPhoto";
            if (ModelState.IsValid)
            {
               
                if (user.PhotoFile != null)
                {
                    var folder = "/Content/UserPhoto";
                    var file = string.Format("{0}.png", user.user_id);
                    var response = FileHelper.UploadFile.UploadPhoto(user.PhotoFile, folder, file);
                    if (response)
                    {
                        var pic = string.Format("{0}/{1}", folder, file);
                        user.profile_pic = pic;

                    }
                }


                db.Entry(user).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.usertype_id = new SelectList(db.usertypes, "usertype_id", "usertype_name", user.usertype_id);
            return View(user);
        }

        // GET: users/Delete/5
        public ActionResult Delete(int? id)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["last_name"])))
            {
                return RedirectToAction("Login", "Home");
            }
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            user user = db.users.Find(id);
            if (user == null)
            {
                return HttpNotFound();
            }
            return View(user);
        }

        // POST: users/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            if (string.IsNullOrEmpty(Convert.ToString(Session["last_name"])))
            {
                return RedirectToAction("Login", "Home");
            }
            user user = db.users.Find(id);
            db.users.Remove(user);
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
