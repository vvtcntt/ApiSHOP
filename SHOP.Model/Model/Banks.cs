using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblBanks")]
    public class Banks:Auditable
    {
        public string Address { set; get; }
        public string NameBank { set; get; }
        public string NumberBank { set; get; }
        public string Images { set; get; }
    }
}
