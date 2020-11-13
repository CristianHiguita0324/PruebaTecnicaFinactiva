using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Cross.Entities
{
   public class MunicipioRegion
    {
        [Required]
        public int IdMunicipio { get; set; }
        [Required]
        [StringLength(1)]
        [RegularExpression("([0-1]+)")]
        public string EliminaAgrega { get; set; }
    }
}
