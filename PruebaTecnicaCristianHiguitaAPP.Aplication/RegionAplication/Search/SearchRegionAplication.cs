using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Domain.RegionDomain.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Search
{
    public class SearchRegionAplication : ISearchRegionAplication
    {
        private readonly ISearchRegionDomain _searchRegionDomain;

        public SearchRegionAplication(ISearchRegionDomain searchRegionDomain)
        {
            _searchRegionDomain = searchRegionDomain;
        }

        public List<RegionDto> GetAll()
        {
           return _searchRegionDomain.GetAll();
        }

        public RegionDetailsMunicipio GetId(int id)
        {
            return _searchRegionDomain.GetID(id);
        }
    }
}
