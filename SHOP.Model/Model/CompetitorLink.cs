using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblCompetitorLink")]
    class CompetitorLink:Auditable
    {
        public int idHomes { set; get; }
        public int idCompetitor { set; get; }
        public string Url { set; get; }
    }
}
