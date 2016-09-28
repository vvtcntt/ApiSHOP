using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblConfig")]
    public class Config
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { set; get; }
        public string Title { set; get; }
        public string Desciption { set; get; }
        public string Keywords { set; get; }
        public string Logo { set; get; }
        public string Favicon { set; get; }
        public bool Popup { set; get; }
        public bool PopupSupport { set; get; }
        public string Content { set; get; }
        public string Name { set; get; }
        public string Address { set; get; }
        public string MobileIN { set; get; }
        public string Mobile { set; get; }
        public string Holine { set; get; }
        public string HolineIN { set; get; }
        public string Email { set; get; }
        public string Slogan { set; get; }
        public string Authorship { set; get; }
        public string FanpageFaceBook { set; get; }
        public string FanpageGoogle { set; get; }
        public string FanpageYoutube { set; get; }
        public string AppFaceBook { set; get; }
        public string Analytics { set; get; }
        public string GoogleMaster { set; get; }
        public string GeoMeta { set; get; }
        public string DMCA { set; get; }
        public string CodeChat { set; get; }
        public string BCT { set; get; }
        public string BNI { set; get; }
        public string SKH { set; get; }
        public bool Coppy { set; get; }
        public bool Social { set; get; }
        public string UserEmail { set; get; }
        public string PassEmail { set; get; }
        public string Host { set; get; }
        public int Port { set; get; }
        public string Color { set; get; }
        public string TimeOut { set; get; }
        public int language { set; get; }






























    }
}
