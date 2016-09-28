using SHOP.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Model.Model
{
    [Table("tblGroupProduct")]
    public class GroupProduct : Auditable
    {
        public virtual IEnumerable<Product> Products { set; get; }
        public virtual IEnumerable<ProductCheck> ProductCheck { set; get; }

        public int idCate { set; get; }

        [Required]
        [MaxLength(200)]
        public string Title { set; get; }
        [Required]
        [MaxLength(300)]
        public string Description { set; get; }
        [Required]
        [MaxLength(500)]
        public string Keyword { set; get; }
        public string Content { set; get; }
        [Required]
        [MaxLength(200)]
        public string Tag { set; get; }
        public int Level { set; get; }
        public bool Priority { set; get; }
        public string Images { set; get; }
        public string Background { set; get; }
        public string iCon { set; get; }
        public string Color { set; get; }
    }
}