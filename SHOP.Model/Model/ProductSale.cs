using SHOP.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblProductSale")]
    public class ProductSale:Auditable
    {
        public string Description { set; get; }
        public string CodeOne { set; get; }

        public string CodeTrue { set; get; }

        public string CodeSale { set; get; }
        public string Content { set; get; }
        public string Slogan { set; get; }

        public string TextRun { set; get; }
        public DateTime StartSale { set; get; }

        public DateTime StopSale { set; get; }
        public string ImageBanner { set; get; }
        public string ImageSale { set; get; }
        public string ImageThumb { set; get; }
        public string Tag { set; get; }




    }
}
