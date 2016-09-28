﻿using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Model.Model
{
    [Table("tblWeb")]
    public class Web
    {
        public int id { set; get; }
        public string Url { set; get; }
        public int Ord { set; get; }
    }
}