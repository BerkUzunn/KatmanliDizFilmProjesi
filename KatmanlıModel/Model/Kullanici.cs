using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KatmanlıModel.Model
{
   public class Kullanici
    {
        [Key]
        public int KullanıcıId { get; set; }




        [Required]
        public string KullanıcıAdı { get; set; }

        [Required]
        public string KullanıcıSifre { get; set; }

        [Required]
        public int Yas { get; set; }

        [Required]
        public string KullanıcıUlke { get; set; }
    }
}
