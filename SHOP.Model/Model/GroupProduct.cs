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
        public virtual IEnumerable<ProductCheck> ProductChecks { set; get; }

        public int idCate { set; get; }

        [Required]
        [MaxLength(200)]
        public string Title { set; get; }
        [Required]
        [MaxLength(500)]
        public string Description { set; get; }
        [Required]
        [MaxLength(500)]
        public string Keyword { set; get; }
        [Column(TypeName ="ntext")]
        public string Content { set; get; }
        [Required]
        [MaxLength(200)]
        public string Tag { set; get; }
        public int Level { set; get; }
        public bool Priority { set; get; }
        [Required]
        [MaxLength(200)]
        public string Images { set; get; }
        [Required]
        [MaxLength(200)]
        public string Background { set; get; }
        [Required]
        [MaxLength(200)]
        public string iCon { set; get; }
        [Required]
        [MaxLength(100)]
        public string Color { set; get; }
        [Required]
        [MaxLength(200)]
        public string Alias { set; get; }
    }
}