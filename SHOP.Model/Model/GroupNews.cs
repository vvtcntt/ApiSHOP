using SHOP.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Model.Model
{
    [Table("tblGroupNews")]
    public class GroupNews : Auditable
    {
        public int ParentID { set; get; }
        public virtual IEnumerable<News> News { set; get; }
        [Required]
        public string Title { set; get; }

        public string Description { set; get; }
        public string Keyword { set; get; }
        public string Tag { set; get; }
        public bool Index { set; get; }
        public string Images { set; get; }
    }
}