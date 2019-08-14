using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Kalbe.Model
{
    [Table("master_customer")]
    public class Customer
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required(AllowEmptyStrings = false)]
        public long ID { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string KodeCustomer { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string NamaCustomer { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string Alamat { get; set; }

        [Column(TypeName = "VARCHAR")]
        [StringLength(20)]
        [Required(AllowEmptyStrings = false)]
        public string NPWP { get; set; }
    }
}