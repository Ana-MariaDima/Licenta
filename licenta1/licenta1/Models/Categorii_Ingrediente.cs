using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace licenta1.Models
{
    public class Categorii_Ingrediente
    {
        [Required]
        public int Id { get;  set; }
        public string Nume_categoriie_ingredient { get; set; }
        public string Descriere_categorie_ingredient { get; set; }
        public List<Ingrediente> Ingrediente { get; set; }



    }
}
