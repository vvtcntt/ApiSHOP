using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblPartner")]
    public class Partner:Auditable
    {
        public string Address { set; get; }
        public string Mobile { set; get; }
        public string Hotline { set; get; }
        public string Email { set; get; }
    }
}
