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
    [Table("tblSupport")]
    public class Support :Auditable
    {
        [Required]
        [MaxLength(100)]
        public string Yahoo { set; get; }
        [Required]
        [MaxLength(100)]
        public string Skyper { set; get; }
        [Required]
        [MaxLength(100)]
        public string Mobile { set; get; }
        [Required]
        [MaxLength(100)]
        public string Phone { set; get; }
        [Required]
        [MaxLength(100)]
        public string Mission { set; get; }
        [Required]
        [MaxLength(200)]
        public string Images { set; get; }
    }
}
