using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using busykids_api.Models;

namespace busykids_api.Controllers
{
    public class UsersController : Controller
    {
        public ApplicationDbContext _context;
        public UsersController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        // GET: Users
        public ActionResult Index()
        {
            var users = _context.User.ToList();
            return Json(users, JsonRequestBehavior.AllowGet);
        }
        public ActionResult GetOne(int id)
        {
            var user = _context.User.Where(u => u.Id == id);
            return Json(user.ToList()[0], JsonRequestBehavior.AllowGet);
        }
    }
}