using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Model.Model
{
    [Table("tblUser")]
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }

        public string FullName { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
        public int Gender { set; get; }
        public string Email { set; get; }
        public string Phone { set; get; }
        public string Address { set; get; }
        public int idModule { set; get; }
        public bool Active { set; get; }
        public int idUser { set; get; }
        public int Ord { set; get; }

        public DateTime DateCreate { set; get; }
    }
}