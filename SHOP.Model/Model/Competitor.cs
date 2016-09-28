using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblCompetitor")]
    class Competitor:Auditable
    {
        public string Code { set; get; }
        public string Website { set; get; }
    }
}
