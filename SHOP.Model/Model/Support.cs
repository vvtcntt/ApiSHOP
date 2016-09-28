using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblSupport")]
    public class Support :Auditable
    {
        public string Yahoo { set; get; }
        public string Skyper { set; get; }
        public string Mobile { set; get; }
        public string Phone { set; get; }
        public string Mission { set; get; }
        public string Images { set; get; }
    }
}
