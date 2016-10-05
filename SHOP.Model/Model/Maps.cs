using SHOP.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Model.Model
{
    [Table("tblMaps")]
    public class Maps : Auditable
    {
        [Required]
        [MaxLength(500)]
        public string Description { set; get; }

        [Column(TypeName = "ntext")]
        public string Content { set; get; }
    }
}