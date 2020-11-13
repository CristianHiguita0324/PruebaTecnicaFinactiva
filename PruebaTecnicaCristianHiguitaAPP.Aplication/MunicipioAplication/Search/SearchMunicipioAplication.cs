using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Search;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.Search
{
    public class SearchMunicipioAplication : ISearchMunicipioAplication
    {
        private readonly ISearchMunicipioDomain _SearchMunicipioDomain;
        public SearchMunicipioAplication(ISearchMunicipioDomain searchMunicipioDomain)
        {
            _SearchMunicipioDomain = searchMunicipioDomain;
        }
        public List<MunicipioDto> GetAll()
        {
            return _SearchMunicipioDomain.GetAll();
        }

        public MunicipioDetails GetId(int id)
        {
            return _SearchMunicipioDomain.GetId(id);
        }
    }
}
