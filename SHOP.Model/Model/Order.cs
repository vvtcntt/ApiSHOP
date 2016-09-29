using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblOrder")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }
        [Required]
        [MaxLength(200)]
        public string Name { set; get; }
        [Required]
        [MaxLength(200)]
        public string Address { set; get; }
        [Required]
        [MaxLength(100)]
        public string Mobile { set; get; }
        [Required]
        [MaxLength(100)]
        public string Mobiles { set; get; }
        [Required]
        [MaxLength(100)]
        public string Email { set; get; }
        [Required]
        [MaxLength(500)]
        public string Description { set; get; }
        [Required]
        [MaxLength(200)]
        public string Name1 { set; get; }
        [Required]
        [MaxLength(200)]
        public string Address1 { set; get; }
        [Required]
        [MaxLength(100)]
        public string Mobiles1 { set; get; }
        [Required]
        [MaxLength(100)]
        public string Email1 { set; get; }
        [Required]
        [MaxLength(200)]
        public string NameCP { set; get; }
        [Required]
        [MaxLength(200)]
        public string AddressCP { set; get; }
        [Required]
        [MaxLength(100)]
        public string MST { set; get; }
        public int TypePay { set; get; }
        public int TypeTransport { set; get; }
        public DateTime DateByy { set; get; }
        public int idUser { set; get; }
        public bool Status { set; get; }
        public bool Active { set; get; }

    }
}
