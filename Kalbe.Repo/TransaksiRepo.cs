using Kalbe.Model;
using Kalbe.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalbe.Repo
{
    public class TransaksiRepo
    {
        public static List<Customer> GetSelect()
        {
            List<Customer> result = new List<Customer>();
            using (var db = new DataContext())
            {
                result = db.Customer.ToList();

                return result;
            }
        }

        public static Boolean SimpanTransaksi(TransactionViewModel mdl)
        {
            try
            {
                MasterTransaction masterTransaction = new MasterTransaction();
                using (DataContext db = new DataContext())
                {
                    masterTransaction.NoFaktur = mdl.NoFaktur;
                    masterTransaction.TransactionDate = mdl.TransactionDate;
                    masterTransaction.NamaCustomer = mdl.NamaCustomer;
                    masterTransaction.Total = mdl.Total;
                    masterTransaction.CashReturn = mdl.CashReturn;

                    db.MasterTransaction.Add(masterTransaction);
                    db.SaveChanges();


                    DetailTransaction detailTransaction = new DetailTransaction();
                    foreach (var item in mdl.TrxDetail)
                    {
                        detailTransaction.NoFaktur = mdl.NoFaktur;
                        detailTransaction.BarangID = item.BarangID;
                        detailTransaction.Quantity = item.Quantity;
                        detailTransaction.Stok = item.Stok;

                        db.DetailTransaction.Add(detailTransaction);
                        db.SaveChanges();
                    }
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
