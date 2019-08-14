using Kalbe.Model;
using Kalbe.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kalbe.Web.Controllers
{
    public class BarangController : Controller
    {
        // GET: Barang
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tampil()
        {
            return Json(BarangRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(Barang barang)
        {
            if (BarangRepo.Createbarang(barang))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
            //return View();
        }

        public ActionResult Edit(int ID)
        {
            return PartialView("_Edit");
        }

        public ActionResult AmbilData(int ID)
        {
            return Json(BarangRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditSimpan(Barang barang)
        {
            if (BarangRepo.Editbarang(barang))
            {
                return Json(new { EditSimpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { EditSimpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult DeleteConfirm(int ID)
        {
            return PartialView("_Delete");
        }

        public ActionResult Delete(int ID, Barang barangmdl)
        {
            if (BarangRepo.Deletebarang(ID, barangmdl))
            {
                return Json(new { Hapus = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Hapus = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }
    }
}