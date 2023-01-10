using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KatmanlıModel.Model
{
    public class Admin
    {
        [Key]
        public int AdminId { get; set; }

        public string AdminAdı { get; set; }

        [StringLength(20), Required]
        public string AdminSifre { get; set; }
    }
}
