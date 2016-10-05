using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHOP.Web.Models
{
    public class ColorProductViewModel
    {
        public string Image { set; get; }

        public virtual IEnumerable<ConnectColorProductViewModel> ConnectColorProducts { set; get; }
    }
}