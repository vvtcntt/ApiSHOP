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
    [Table("tblBanks")]
    public class Banks:Auditable
    {
        [Required]
        [MaxLength(200)]
        public string Address { set; get; }
        [Required]
        [MaxLength(200)]
        public string NameBank { set; get; }
        [Required]
        [MaxLength(100)]
        public string NumberBank { set; get; }
        [Required]
        [MaxLength(200)]
        public string Images { set; get; }
    }
}
