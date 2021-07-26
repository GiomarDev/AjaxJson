using AjaxJson.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxJson.Controllers
{
    public class JsonController : Controller
    {
        // GET: Json
        public ActionResult Index()
        {
            /*List<tblTable> lst;
            using (AjaxJsonEntities db= new AjaxJsonEntities()) {
                  lst = (from d in db.tblTable
                           select d).ToList();
            }*/
            //ViewBag.Ngon.lst = lst;
            return View(/*lst*/);
        }

        public JsonResult ObtenerPersonas() 
        {
            List<tblTable> lst;
            using (AjaxJsonEntities db = new AjaxJsonEntities())
            {
                lst = (from d in db.tblTable
                       select d).ToList();
            }

            return Json(lst, JsonRequestBehavior.AllowGet);
        }

    }
}