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
    [Table("tblMaps")]
    public class Maps:Auditable
    {
        [Required]
        [MaxLength(500)]
        public string Description { set; get; }
        [Column(TypeName ="ntext")]
        public string Content { set; get; }
    }
}
