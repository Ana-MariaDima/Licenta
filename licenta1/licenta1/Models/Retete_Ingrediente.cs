using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace licenta1.Models
{
    public class Retete_Ingrediente
    {
        public int Id { set; get; }
        public int Id_reteta { get; set; }
        public int Id_ingredient { get; set; }
        public string Cantitate_Ingredient { get; set; }
        public string Observatii { get; set; }
       
    }
}
