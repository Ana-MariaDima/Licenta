using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace licenta1.Models
{
    public class Ingrediente
    {
        [Required]
        public int Id{ set; get; }
        public string Nume_ingredient { set; get; }
        public int Categorie_ingredient { set; get; }
        public List<Retete_Ingrediente> Reteta_ingrediente { get; set; }
    }
}
