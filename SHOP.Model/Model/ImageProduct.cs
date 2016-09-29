using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblImageProduct")]
    public class ImageProduct
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }
        public int idProduct { set; get; }
        [Required]
        [MaxLength(100)]
        public string Name { set; get; }
        public int Type { set; get; }
        [Required]
        [MaxLength(200)]
        public string  Images { set; get; }
    }
}
