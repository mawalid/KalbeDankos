using Kalbe.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalbe.Repo
{
    public class BarangRepo
    {
        public static List<Barang> GetAll()
        {
            List<Barang> result = new List<Barang>();
            using (var db = new DataContext())
            {
                result = db.Barang.ToList();

                return result;
            }
        }

        public static bool Createbarang(Barang barangmdl)
        {
            try
            {
                Barang barang = new Barang();
                using (DataContext db = new DataContext())
                {
                    barang.KodeBarang = barangmdl.KodeBarang;
                    barang.NamaBarang = barangmdl.NamaBarang;
                    barang.Satuan = barangmdl.Satuan;
                    barang.Stok = barangmdl.Stok;
                    barang.Harga = barangmdl.Harga;

                    db.Barang.Add(barang);
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Barang GetByID(int ID)
        {
            Barang barang = new Barang();
            using (DataContext db = new DataContext())
            {
                barang = db.Barang.Where(d => d.ID == ID).First();
                return barang;
            }
        }

        public static Boolean Editbarang(Barang barang)
        {
            try
            {
                Barang dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Barang.Where(d => d.ID == barang.ID).First();//d adalah suatu elemen di dalam dep, dimana d adalah dep.id, kemudian dep.id dibandingkan dengan ID.
                    dep.KodeBarang = barang.KodeBarang;
                    dep.NamaBarang = barang.NamaBarang;
                    dep.Satuan = barang.Satuan;
                    dep.Stok = barang.Stok;
                    dep.Harga = barang.Harga;

                    db.Entry(dep).State = EntityState.Modified;//dep diperlakukan sebagai Entry di dalam database organisasi (System.Data.Entity.EntityState.Modified)
                    db.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {
                return false;

            }
        }

        public static bool Deletebarang(int ID, Barang barangmdl)
        {
            try
            {
                Barang dep;
                using (DataContext db = new DataContext())
                {
                    dep = db.Barang.Where(d => d.ID == ID).First();

                    db.Entry(dep).State = System.Data.Entity.EntityState.Deleted;
                    db.SaveChanges();
                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
    }
}
