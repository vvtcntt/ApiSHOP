using SHOP.Model.Abstract;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Model.Model
{
    [Table("tblVideo")]
    internal class Video : Auditable
    {
        public string code { set; get; }
        public bool AutoPlay { set; get; }
    }
}