using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Model.Model
{
    [Table("tblWeb")]
    public class Web
    {
        public int id { set; get; }
        [Required]
        [MaxLength(200)]
        public string Url { set; get; }
        public int Ord { set; get; }
    }
}