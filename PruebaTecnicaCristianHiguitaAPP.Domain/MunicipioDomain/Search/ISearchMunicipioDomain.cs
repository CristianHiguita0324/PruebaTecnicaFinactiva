using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Search
{
   public interface ISearchMunicipioDomain
    {
        List<MunicipioDto> GetAll();

        MunicipioDetails GetId(int id);
    }
}
