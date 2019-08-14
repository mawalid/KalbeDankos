using Kalbe.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalbe.Repo
{
    public class CustomerRepo
    {
        public static List<Customer> GetAll()
        {
            List<Customer> result = new List<Customer>();
            using (var db = new DataContext())
            {
                result = db.Customer.ToList();

                return result;
            }
        }

        public static bool Createcustomer(Customer customermdl)
        {
            try
            {
                Customer customer = new Customer();
                using (DataContext db = new DataContext())
                {
                    customer.KodeCustomer = customermdl.KodeCustomer;
                    customer.NamaCustomer = customermdl.NamaCustomer;
                    customer.Alamat = customermdl.Alamat;
                    customer.NPWP = customermdl.NPWP;

                    db.Customer.Add(customer);
                    db.SaveChanges();
                }
                return true;

            }
            catch (Exception)
            {

                return false;
            }
        }

        public static Customer GetByID(int ID)
        {
            Customer customer = new Customer();
            using (DataContext db = new DataContext())
            {
                customer = db.Customer.Where(d => d.ID == ID).First();

                return customer;
            }
        }

        public static bool Editcustomer(Customer customermdl)
        {
            try
            {
                Customer customer;
                using (DataContext db = new DataContext())
                {
                    customer = db.Customer.Where(d => d.ID == customermdl.ID).First();
                    customer.KodeCustomer = customermdl.KodeCustomer;
                    customer.NamaCustomer = customermdl.NamaCustomer;
                    customer.Alamat = customermdl.Alamat;
                    customer.NPWP = customermdl.NPWP;

                    db.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                    db.SaveChanges();

                }
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }

        public static bool Deletecustomer(int ID, Customer customermdl)
        {
            try
            {
                Customer customer;
                using (DataContext db = new DataContext())
                {
                    customer = db.Customer.Where(d => d.ID == ID).First();
                    customer.KodeCustomer = customermdl.KodeCustomer;
                    customer.NamaCustomer = customermdl.NamaCustomer;
                    customer.Alamat = customermdl.Alamat;
                    customer.NPWP = customermdl.NPWP;

                    db.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
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
