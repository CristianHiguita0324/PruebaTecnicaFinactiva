using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Cross.Entities
{
   public class MunicipioDto
    {
        public int IdMunicipio { get; set; }

        [Required]
        [StringLength(60)]
        public string NombreMunicipio { get; set; }

        [Required]
        public bool Estado { get; set; }

        [Required]
        [StringLength(1)]
        [RegularExpression("([0-1]+)")]
        public string EliminaAgrega { get; set; }
    }
}
