using SHOP.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Model.Model
{
    [Table("tblUrl")]
    public class Url : Auditable
    {
        [Required]
        [MaxLength(200)]
        public string Link { set; get; }

        public bool Rel { set; get; }
        public int idCate { set; get; }
    }
}