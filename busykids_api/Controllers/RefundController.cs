using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using busykids_api.Models;

namespace busykids_api.Controllers
{
    public class RefundController : Controller
    {
        public ApplicationDbContext _context;
        public RefundController()
        {
            _context = new ApplicationDbContext();
        }
        protected override void Dispose(bool disposing)
        {
            _context.Dispose();
        }
        
        public JsonResult Create(Refund model)
        {
            _context.Refund.Add(model);
            _context.SaveChanges();
            return Json(model);
        }
    }
}