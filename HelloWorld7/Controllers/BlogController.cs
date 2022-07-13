using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorld7.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            // veritabanındaki bütün bilgileri al ve View üzerinden gönder.
            //kendisine gelen blog bilgilerini dinamik içeik üreten View yapısı bunu statik Html'ye çevirir.
            //bloglar
            return View();
        }
        public ActionResult Details()
        {
            return View();
        }
        
    }
}