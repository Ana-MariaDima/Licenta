using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace licenta1.Models
{
    public class Retete
    {
        [Required]
        public int Id { get; set; }
        public String Nume_reteta { set; get; }
        public string Descriere_reteta { set; get; }
        public int Id_categorie_reteta { set; get; }
        public int Id_bucatar { set; get; }
        public string Link_reteta { set; get; }
        public string Poza_reteta { set; get; }
        public int durata_preparare { set; get; }
        public int durata_gatire { set; get; }
        public int durata_totala { set; get; }
        public float Scor_reteA { set; get; }




    }
}
