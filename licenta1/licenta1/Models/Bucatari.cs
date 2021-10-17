using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace licenta1.Models
{
    public class Bucatari
    {
        [Required]
        public int Id { get; set; }
        public string Pseudonume_bucarat { set; get; }
        public string Nume_bucarat  { set; get; }
        public List<Retete> Retete { get; set; }

    }
}
