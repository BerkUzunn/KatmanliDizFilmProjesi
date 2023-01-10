using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KatmanlıModel.Model
{
    public class DiziYorumlar
    {
        [Key]
        public int ListeNo { get; set; }

        public string Yorumlar { get; set; }

        [Range(1, 10, ErrorMessage = "1 ile 10 arasında puanlayınız")]

        public int DiziPuan { get; set; }


        [ForeingKey("Diziler")]

        public int DiziId { get; set; }

       

        public virtual Diziler Diziler { get; private set; }

        [ForeingKey("Kullanıcı")]

        public int KullanıcıId { get; set; }
      


        public virtual Kullanici Kullanıcı { get; private set; }

  

      

    }
}
