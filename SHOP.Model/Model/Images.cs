using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblImages")]
   public class Images:Auditable
    {
        public int idCate { set; get; }
        [ForeignKey("id")]
        public virtual GroupImage GroupImage { set; get; }
        public string Image { set; get; }
        public string Url { set; get; }
        public bool Link { set; get; }
        public string Color { set; get; }


    }
}
