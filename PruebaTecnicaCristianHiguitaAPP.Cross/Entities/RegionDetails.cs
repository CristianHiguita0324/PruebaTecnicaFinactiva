using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Cross.Entities
{
   public class RegionDetails: RegionDto
    {
        public List<MunicipioRegion> Municipios { get; set; }
    }
}
