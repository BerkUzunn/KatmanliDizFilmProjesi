using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace KatmanlıModel.Model
{
    public class Diziler
    {
        [Key]

        public int DiziId  { get; set; }

        public string DiziAdı { get; set; }

        public string DiziAcıklama { get; set; }

        public string ImageUrl { get; set; }

        public string DiziYönetmen { get; set; }

        public int DiziYıl { get; set; }

        public string DiziTür { get; set; }

        public int DiziPuan { get; set; }

        public string DiziYayıncı { get; set; } 

      
    }
}
