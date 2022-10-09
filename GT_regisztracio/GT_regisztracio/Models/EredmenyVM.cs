using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace GT_regisztracio.Models
{
    public class EredmenyVM
    {
        [DisplayName("Név")]
        public string Nev { get; set; }

        [DisplayName("Neptun")]
        public string Neptun { get; set; }

        [DisplayName("Összes pont")]
        public int Osszpont { get; set; }
    }
}
