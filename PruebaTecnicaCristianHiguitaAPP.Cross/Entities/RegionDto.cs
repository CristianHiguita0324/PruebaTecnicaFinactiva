using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Cross.Entities
{
   public class RegionDto
    {
        [Required]
        public int IdRegion { get; set; }

        [Required]
        [StringLength(60)]
        public string NombreRegion { get; set; }

        public List<MunicipioRegion> Municipios { get; set; }
    }
}
