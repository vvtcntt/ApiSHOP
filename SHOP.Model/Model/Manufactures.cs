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
    [Table("tblManufactures")]
    public class Manufactures:Auditable
    {
        [Required]
        [MaxLength(200)]
        public string Tag { set; get; }
        [Required]
        [MaxLength(500)]
        public string Description { set; get; }
        [Required]
        [MaxLength(200)]
        public string Images { set; get; }
        [Required]
        [MaxLength(500)]
        public string Keywork { set; get; }
        [Required]
        [MaxLength(200)]
        public string Title { set; get; }
        public bool Priority { set; get; }
    }
}
