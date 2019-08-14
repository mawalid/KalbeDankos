using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalbe.Model
{
    [Table("trx_detailtransaksi")]
    public class DetailTransaction
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }

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
