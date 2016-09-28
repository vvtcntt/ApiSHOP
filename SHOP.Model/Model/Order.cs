using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblOrder")]
    public class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string Mobile { set; get; }
        public string Mobiles { set; get; }
        public string Email { set; get; }
        public string Description { set; get; }
        public string Name1 { set; get; }
        public string Address1 { set; get; }
        public string Mobiles1 { set; get; }
        public string Email1 { set; get; }
        public string NameCP { set; get; }
        public string AddressCP { set; get; }
        public string MST { set; get; }
        public int TypePay { set; get; }
        public int TypeTransport { set; get; }
        public DateTime DateByy { set; get; }
        public int idUser { set; get; }
        public bool Status { set; get; }
        public bool Active { set; get; }

    }
}
