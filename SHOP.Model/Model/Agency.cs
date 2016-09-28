using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("Agency")]
   public class Agency: Auditable
    {
        public virtual GroupAgency GroupAgency { set; get; }
        public string Title { set; get; }
         public string Description { set; get; }
        public string Keyword { set; get; }
        public string Content { set; get; }
        public string Tag { set; get; }
        public int idMenu { set; get; }
        public string Images { set; get; }
        public string Address { set; get; }
        public string Mobile { set; get; }
        public string People { set; get; }
        public string Email { set; get; }
        public string Tabs { set; get; }
    }
}
