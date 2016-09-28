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
    [Table("tblGroupImage")]
    public class GroupImage:Auditable
    {
       public virtual IEnumerable<Images> Images { set; get; }
    }
}
