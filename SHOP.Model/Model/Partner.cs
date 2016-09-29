using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblPartner")]
    public class Partner:Auditable
    {
        [Required]
        [MaxLength(200)]
        public string Address { set; get; }
        [Required]
        [MaxLength(200)]
        public string Mobile { set; get; }
        [Required]
        [MaxLength(100)]
        public string Hotline { set; get; }
        [Required]
        [MaxLength(100)]
        public string Email { set; get; }
    }
}
