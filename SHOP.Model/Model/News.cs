using SHOP.Model.Abstract;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace SHOP.Model.Model
{
    [Table("tblNews")]
    public class News : Auditable
    {
        [ForeignKey("id")]
        public virtual GroupNews GroupNews { set; get; }
       public int idCate { set; get; }
        public string Title { set; get; }

        public string Description { set; get; }
        public string Keyword { set; get; }
        public string Content { set; get; }
        public string Images { set; get; }
        public bool ViewHomes { set; get; }
        public string Tag { set; get; }
        public string Tabs { set; get; }

    }
}
