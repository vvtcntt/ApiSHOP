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
    [Table("tblCompetitorLink")]
    public class CompetitorLink:Auditable
    {
        public int idHomes { set; get; }
        [ForeignKey("idHomes")]
        public virtual CompetitorHomes CompetitorHomes { set; get; }
        public int idCompetitor { set; get; }
        [ForeignKey("idCompetitor")]
        public virtual Competitor Competitors { set; get; }
        [Required]
        [MaxLength(200)]
        public string Url { set; get; }
    }
}
