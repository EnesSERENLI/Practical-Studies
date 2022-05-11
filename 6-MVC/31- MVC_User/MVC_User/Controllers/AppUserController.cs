using MVC_User.Models;
using System.Collections.Generic;
using System.Web.Mvc;

namespace MVC_User.Controllers
{
    public class AppUserController : Controller
    {
        public static List<AppUser> userList = new List<AppUser>()
        {
            new AppUser{ID = 1, UserName ="CrestFall", FirstName ="Enes",LastName = "Serenli",Email = "enes.serenli@hotmail.com",Password ="1234"},
            new AppUser{ID = 2, UserName ="Nuguri", FirstName ="Semih",LastName = "Serenli",Email = "semih.serenli@hotmail.com",Password ="1234"}
        };

        // GET: AppUser
        public ActionResult Index()
        {
            return View(userList);
        }

        public ActionResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ActionResult AddUser(AppUser user)
        {
            user.ID = userList.Count + 1;
            userList.Add(user);
            return RedirectToAction("Index");
        }

        //Details
        public ActionResult Details(int id)
        {
            var userDetails = userList.Find(x => x.ID == id);
            return View(userDetails);
        }

        //Update todo:siz yapın
        //GET : UpdateUser
        public ActionResult UpdateUser(int id) 
        {
            var updated = userList.Find(x => x.ID == id);
            return View(updated);
        }

        [HttpPost]
        public ActionResult UpdateUser(AppUser updated)
        {
            foreach (AppUser user in userList)
            {
                if (updated.ID == user.ID)
                {
                    user.ID = updated.ID;
                    user.UserName = updated.UserName;
                    user.FirstName = updated.FirstName;
                    user.LastName = updated.LastName;
                    user.Email = updated.Email;
                    user.Password = updated.Password;
                    break;
                }
            }
            return RedirectToAction("Index");
        }
        //Delete

        public ActionResult Delete(int id)
        {
            var userDeleted = userList.Find(x => x.ID == id);
            userList.Remove(userDeleted);
            return RedirectToAction("Index", "AppUser");
        }
    }
}