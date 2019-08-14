using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kalbe.Model
{
    [Table("master_barang")]
    public class Barang
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(AllowEmptyStrings =false)]
        public long ID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string KodeBarang { get; set; }

        [Column(TypeName ="VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings =false)]
        public string NamaBarang { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string Satuan { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int Stok { get; set; }

        [Required(AllowEmptyStrings = false)]
        public int Harga { get; set; }
    }
}