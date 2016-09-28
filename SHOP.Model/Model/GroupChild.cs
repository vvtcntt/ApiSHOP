using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblGroupChild")]
    public class GroupChild :Auditable
    {
        public string Title { set; get; }

        public string Description { set; get; }
        public string Keyword { set; get; }
        public int idParent { set; get; }
        public string Tag { set; get; }
        public bool Priority { set; get; }
  }
}
