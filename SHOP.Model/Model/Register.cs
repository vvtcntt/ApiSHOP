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
    [Table("tblRegister")]
    public class Register:Auditable
    {
        [Required]
        [MaxLength(200)]
        public string Email { set; get; }
        [Required]
        [MaxLength(100)]
        public string Mobile { set; get; }

        public int idCate { set; get; }
    }
}
