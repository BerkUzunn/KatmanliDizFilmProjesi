using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace KatmanlıModel.Model
{
    public class DiziIzlemeListesi
    {
        [Key]
        public int ListeNo  { get; set; }

        [ForeingKey("Diziler")]

        public int DiziId { get; set; }

        public int DiziAdı { get; set; }

        public virtual Diziler Diziler { get; private set; }

        [ForeingKey("Kullanıcı")]

        public int KullanıcıId { get; set; }

      

        public virtual Kullanici Kullanıcı { get; private set; }
    }
}
