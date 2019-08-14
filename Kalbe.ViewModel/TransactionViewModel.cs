using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalbe.ViewModel
{
    public class TransactionViewModel
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string NoFaktur { get; set; }

        [Column(TypeName = "DateTime")]
        [Required(AllowEmptyStrings = false)]
        public DateTime TransactionDate { get; set; }

        [Column(TypeName = "VARCHAR")]
        [Required(AllowEmptyStrings = false)]
        public string NamaCustomer { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int Total { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int CashReturn { get; set; }

        public Collection<TransactionDetail> TrxDetail { get; set; }
    }

    public class TransactionDetail
    {
        [Required(AllowEmptyStrings = false)]
        public int BarangID { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int Stok { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int Quantity { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string NoFaktur { get; set; }
    }
}

