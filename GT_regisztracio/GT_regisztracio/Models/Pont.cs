using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GT_regisztracio.Models
{
    public class Pont
    {
        [Key]
        public string UID { get; set; }

        [StringLength(100)]
        public string PontozoNev { get; set; }

        [Range(1,10)]
        public int Tapasztalat { get; set; }

        [Range(1, 10)]
        public int SzervezoKepesseg { get; set; }

        [Range(1, 10)]
        public int Szemelyiseg { get; set; }
    }
}
