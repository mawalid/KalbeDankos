using Kalbe.Repo;
using Kalbe.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kalbe.Web.Controllers
{
    public class TransaksiController : Controller
    {
        // GET: Transaksi
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Select()
        {
            return Json(TransaksiRepo.GetSelect(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult SaveTransaction(TransactionViewModel mdl)
        {
            if (TransaksiRepo.SimpanTransaksi(mdl))
            {
                return Json(new { hasil = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { hasil = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}