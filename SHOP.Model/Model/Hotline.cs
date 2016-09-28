using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblHotline")]

    class Hotline:Auditable
    {
        public string Mobile { set; get; }
        public string Holine { set; get; }
    }
}
