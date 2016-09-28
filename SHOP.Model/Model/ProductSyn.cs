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
    [Table("tblProductSyn")]
    public class ProductSyn :Auditable
    {
 
        [Required]
        public string Code { set; get; }
        [Required]
        public string CodeSyn { set; get; }

        [Required]
        public string Title { set; get; }

        [Required]
        public string Description { set; get; }

        [Required]
        public string Keyword { set; get; }

        public string Content { set; get; }
        public string Info { set; get; }
        public string Parameter { set; get; }
        public string Tag { set; get; }
        public string ImageLinkThumb { set; get; }
        public string ImageLinkDetail { set; get; }

        [Required]
        public int Price { set; get; }

        [Required]
        public string PriceSale { set; get; }

        public bool Vat { set; get; }
        public string Warranty { set; get; }
        public string Address { set; get; }
        public bool Transport { set; get; }
        public string Access { set; get; }
        public string Sale { set; get; }
        public string Note { set; get; }
        public string Size { set; get; }
        public string ImageSale { set; get; }
        public bool Status { set; get; }
        public bool ProductSale { set; get; }
        public bool Priority { set; get; }
        public bool New { set; get; }
        public bool ViewHomes { set; get; }
        public int Visit { set; get; }
    }
}
