using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KatmanlıModel.Model
{
   public class Filmler
    {
        [Key]

        public int FilmId { get; set; }

        public string FilmAdı { get; set; }

        public string FilmAcıklma { get; set; }

        public string ImageUrl { get; set; }

        public string FilmYönetmen { get; set; }

        public int FilmYıl { get; set; }
        
        public string FilmTür { get; set; }

        public int FilmPuan { get; set; }

        public string Yayıncı { get; set; }

 
    }
}
