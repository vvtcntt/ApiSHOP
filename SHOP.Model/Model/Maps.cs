using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblMaps")]
    class Maps:Auditable
    {
public string Description { set; get; }
        public string Content { set; get; }
    }
}
