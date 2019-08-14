using Kalbe.Model;
using Kalbe.Repo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Kalbe.Web.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Tampil()
        {
            return Json(CustomerRepo.GetAll(), JsonRequestBehavior.AllowGet);
        }

        public ActionResult Create()
        {
            return PartialView("_Create");
        }

        public ActionResult Save(Customer customer)
        {
            if (CustomerRepo.Createcustomer(customer))
            {
                return Json(new { Simpan = "Berhasil" }, JsonRequestBehavior.AllowGet);
            }
            else
            {
                return Json(new { Simpan = "Gagal" }, JsonRequestBehavior.AllowGet);
            }
        }

        public ActionResult Edit(int ID)
        {
            return PartialView("_Edit");
        }

        public ActionResult AmbilData(int ID)
        {
            return Json(CustomerRepo.GetByID(ID), JsonRequestBehavior.AllowGet);
        }

        public ActionResult EditSimpan(Customer customer)
        {
            if (CustomerRepo.Editcustomer(customer))
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

        public ActionResult Delete(int ID, Customer customer)
        {
            if (CustomerRepo.Deletecustomer(ID, customer))
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