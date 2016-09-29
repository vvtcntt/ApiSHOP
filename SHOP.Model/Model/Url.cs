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
    [Table("tblUrl")]
    public class Url:Auditable
    {
        [Required]
        [MaxLength(200)]
        public string Link { set; get; }
        public bool Rel { set; get; }
        public int idCate { set; get; }
    }
}
