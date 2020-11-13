using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.RegionDomain.Search
{
   public interface ISearchRegionDomain
    {
        List<RegionDto> GetAll();

        RegionDetailsMunicipio GetID(int id);
    }
}
