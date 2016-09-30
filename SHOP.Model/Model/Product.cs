using SHOP.Model.Abstract;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Model.Model
{
    [Table("tblProduct")]
    public class Product : Auditable
    {
        [ForeignKey("idCate")]
        public virtual GroupProduct GroupProduct { set; get; }

        public int idCate { set; get; }
        [Required]
        [Column(TypeName ="varchar")]
        [MaxLength(100)]
        public string Code { set; get; }

        [Required]
        [MaxLength(200)]
        public string Title { set; get; }

        [Required]
        [MaxLength(300)]
        public string Description { set; get; }

        [Required]
        [MaxLength(500)]
        public string Keyword { set; get; }
        [Column(TypeName ="ntext")]
        public string Content { set; get; }
        [Column(TypeName = "ntext")]
        public string Info { set; get; }
        [Column(TypeName = "ntext")]
        public string Parameter { set; get; }
        [Required]
        [MaxLength(500)]
        public string Tag { set; get; }
        [Required]
        [MaxLength(200)]
        public string ImageLinkThumb { set; get; }
        [Required]
        [MaxLength(200)]
        public string ImageLinkDetail { set; get; }

        [Required]
        public int Price { set; get; }

        [Required]
        [MaxLength(700)]

        public string PriceString { set; get; }
        
        [Required]
        public int PriceSale { set; get; }

        [Required]
        [MaxLength(700)]

        public string PriceSaleString { set; get; }
        public bool Vat { set; get; }
        [Required]
        [MaxLength(50)]
        public string Warranty { set; get; }
        [Required]
        [MaxLength(50)]
        public string Address { set; get; }
        public bool Transport { set; get; }
        [Required]
        [MaxLength(300)]
        public string Access { set; get; }
        [Required]
        [MaxLength(300)]
        public string Sale { set; get; }
        [Required]
        [MaxLength(300)]
        public string Note { set; get; }
        [Required]
        [MaxLength(200)]
        public string Size { set; get; }
        [Required]
        [MaxLength(200)]
        public string ImageSale { set; get; }
        public bool Status { set; get; }
        public bool ProductSale { set; get; }
        public bool Priority { set; get; }
        public bool New { set; get; }
        public bool ViewHomes { set; get; }
        public int Visit { set; get; }
        [Required]
        [MaxLength(500)]
        public string Tabs { set; get; }
        public int idVideo { set; get; }
        public virtual IEnumerable<ConnectColorProduct> ConnectColorProducts { set; get; }
        public virtual IEnumerable<ConnectCriteria> ConnectCriterias { set; get; }
    }
}