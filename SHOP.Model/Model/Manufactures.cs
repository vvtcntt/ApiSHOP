using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblManufactures")]
    public class Manufactures:Auditable
    {
public string Tag { set; get; }
        public string Description { set; get; }
        public string Images { set; get; }
        public string Title { set; get; }
        public bool Priority { set; get; }
    }
}
