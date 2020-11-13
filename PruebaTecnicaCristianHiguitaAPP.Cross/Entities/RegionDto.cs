using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Cross.Entities
{
   public class RegionDto
    {
        public int IdRegion { get; set; }

        [Required]
        [StringLength(60)]
        public string NombreRegion { get; set; }

        public List<MunicipioDto> Municipios { get; set; }
    }
}
