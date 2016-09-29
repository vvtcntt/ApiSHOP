using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
   [Table("tblProductChecl")]
    public class ProductConnect
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }

     
        public int idSyn { set; get; }

        public int idpd { set; get; }
        [Column(TypeName ="ntext")]
        public string Content { set; get; }
        [Column(TypeName = "ntext")]
        public string Parameter { set; get; }

    }
}
