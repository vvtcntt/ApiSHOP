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
    [Table("CompetitorHomes")]
    public class CompetitorHomes :Auditable
    {
        [Required]
        [MaxLength(200)]
        public string CodeProduct { set; get; }
        public virtual IEnumerable<CompetitorLink> CompetitorLinks { set; get; }

    }
}
