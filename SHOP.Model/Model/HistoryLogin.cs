using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblHistoryLogin")]
    public class HistoryLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }
        [Required]
        [MaxLength(100)]
        public string FullName { set; get; }
        [Required]
        [MaxLength(100)]
        public string Task { set; get; }
        public int idUser { set; get; }
        public DateTime DateCreate { set; get; }
        public bool Active { set; get; }


    }
}
