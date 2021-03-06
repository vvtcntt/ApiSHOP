﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SHOP.Model.Abstract
{
    public abstract class Auditable : IAuditable
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { set; get; }

        [Required]
        public string Name { set; get; }

        public DateTime DateCreate { set; get; }
        public bool Active { set; get; }
        public int idUser { set; get; }
        public int Ord { set; get; }
    }
}