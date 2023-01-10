using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KatmanlıModel.Model
{
    public class FilmYorumlar
    {
        [Key]

        public int ListeNo { get; set; }

        public string Yorumlar { get; set; }

        [Range(1,10,ErrorMessage ="1 ile 10 arasında puanlayınız")]
        public int FilmPuan { get; set; }



        [ForeingKey("Filmler")]

        public int FilmId { get; set; }

     

        public virtual Filmler Filmler { get; private set; }


        [ForeingKey("Kullanıcı")]

        public int KullanıcıId { get; set; }
    


        public virtual Kullanici Kullanıcı { get; private set; }

    }
}
