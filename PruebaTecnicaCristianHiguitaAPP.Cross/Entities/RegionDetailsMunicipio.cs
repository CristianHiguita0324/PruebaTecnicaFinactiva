using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Cross.Entities
{
  public  class RegionDetailsMunicipio: RegionDto
    {
       public List<MunicipioDto> municipios { get; set; }
    }
}
