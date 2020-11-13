using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Cross.Entities
{
   public class MunicipioDetails:MunicipioDto
    {
        public List<RegionDto> Regions { get; set; }
    }
}
