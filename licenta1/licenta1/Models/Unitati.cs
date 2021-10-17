using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace licenta1.Models
{
    public class Unitati
    {
        [Required]
        public int Id_unitate { set; get; }
        public string Nume_unitate { get; set; }
        public List<Retete_Ingrediente> Reteta_ingrediente { get; set; }
    }
}
