using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KatmanlıModel.Model
{
   public class FilmIzlemeListesi
    {
        [Key]

        public int ListeNo { get; set; }

        [ForeingKey("Filmler")]

        public int FilmId { get; set; }

        public String FilmAdı { get; set; }

        public virtual Filmler Filmler { get; private set; }


        [ForeingKey("Kullanıcı")]

        public int KullanıcıId { get; set; }

        public virtual Kullanici Kullanıcı { get; private set; }
    }
}
