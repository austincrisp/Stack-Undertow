using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Stack_Undertow.Models;

namespace Stack_Undertow.Controllers
{
    [Authorize]
    public class UserController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        [Route("u/{username}")]
        public ActionResult Index(string userName)
        {
            ApplicationUser userInstance = db.Users.Where(u => u.UserName == userName).FirstOrDefault();
            return View(userInstance);
        }
    }
}