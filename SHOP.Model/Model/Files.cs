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
    [Table("tblFiles")]
    public class Files :Auditable
    {
        [Required]
        [MaxLength(200)]
        public string Title { set; get; }
        [Required]
        [MaxLength(500)]
        public string Description { set; get; }
        [Required]
        [MaxLength(500)]
        public string Keyword { set; get; }
        [Required]
        [MaxLength(200)]
        public string File { set; get; }
        [Required]
        [MaxLength(200)]
        public string Images { set; get; }
        public int Cate { set; get; }
        public int idp { set; get; }
        public int idg { set; get; }
        public int Tag { set; get; }

    }
}
