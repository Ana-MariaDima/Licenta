using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace licenta1.Models
{
    public class Categorii_Retete
    {
        [Required]
        public int Id { get; set; }
        public string Nume_Categorie_Retete { set; get; }
        public List<Retete> Retete { get; set; }


    }
}
