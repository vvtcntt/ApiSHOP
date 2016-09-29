using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblCriteria")]
    public class Criteria:Auditable
    {
        public int idCate { set; get; }
        public bool Priority { set; get; }
        public bool Style { set; get; }
        public virtual IEnumerable<ConnectCriteria> ConnectCriterias { set; get; }
    }
}
