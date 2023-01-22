using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using online_commercial_automation.Models.Siniflar;

namespace online_commercial_automation.Controllers
{
    public class UrunKontrollerController : Controller
    {
        // GET: UrunKontroller
        Context c = new Context();
        public ActionResult Index()
        {
            var urunler = c.Uruns.Where(x => x.Durum == true).ToList();
            return View(urunler);
        }
        //yeni urun ekleme islemi
        [HttpGet]
        public ActionResult YeniUrun()
        { //yeni urun ekleme dropdownlistfor Important
            List<SelectListItem> deger1 = (from x in c.Kategoris.ToList()
                                       select new SelectListItem
                                       {
                                           Text =x.KategoriAD,
                                           Value=x.KategoriID.ToString()
                                       }).ToList();
            ViewBag.dgr1 = deger1;
            return View();
        }
        [HttpPost]
        public ActionResult YeniUrun(Urun p)
        {
            c.Uruns.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        //urun silme islemi  Durumu False Yapma Iyi Yol Bu 
        public ActionResult UrunSil(int id)
        {
            var deger = c.Uruns.Find(id);
            deger.Durum = false;
            c.SaveChanges();
            return RedirectToAction("Index");
        }

    }
}