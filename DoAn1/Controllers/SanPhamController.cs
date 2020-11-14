using Model.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DoAn1.Controllers
{
    public class SanPhamController : Controller
    {
        // GET: SanPham
        public ActionResult Index()
        {
            var productDao = new ProductDao();
            ViewBag.ListNike = productDao.ListNike(4);
            ViewBag.ListMLB = productDao.ListMLB(4);
            ViewBag.ListAdidas = productDao.ListAdidas(4);
            return View();
        }
    }
}