﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SHOP.Model.Model
{
    [Table("tblHistoryLogin")]
    class HistoryLogin
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }
        public string FullName { set; get; }
        public string Task { set; get; }
        public int idUser { set; get; }
        public DateTime DateCreate { set; get; }
        public bool Active { set; get; }


    }
}
