using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GT_regisztracio.Models
{
    public class Szervezo
    {
        [Key]
        public string UID { get; set; }

        [DisplayName("Vezetéknév")]
        [StringLength(100)]
        public string Vezeteknev { get; set; }

        [DisplayName("Keresztnév")]
        [StringLength(100)]
        public string Keresztnev { get; set; }

        [DisplayName("Neptun")]
        [StringLength(6)]
        public string Neptun { get; set; }

        [DisplayName("Email")]
        [StringLength(100)]
        public string Email { get; set; }

        [DisplayName("Telefon")]
        [StringLength(20)]
        public string Telefon { get; set; }

        [DisplayName("Bemutatkozás")]
        [StringLength(1500)]
        public string Bemutatkozas { get; set; }

        [DisplayName("Pozíció")]
        [StringLength(100)]
        public string Pozicio { get; set; }

        [DisplayName("Megjegyzés")]
        [StringLength(300)]
        public string Megjegyzes { get; set; }

        public virtual ICollection<Pont> Pontok { get; set; }        
    }
}
