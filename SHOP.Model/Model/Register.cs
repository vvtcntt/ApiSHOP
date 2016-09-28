using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblRegister")]
    public class Register:Auditable
    {
        public string Email { set; get; }
        public string Mobile { set; get; }
        public int idCate { set; get; }
    }
}
