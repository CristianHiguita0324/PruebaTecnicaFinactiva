using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.Search
{
    public interface ISearchMunicipioAplication
    {
        List<MunicipioDto> GetAll();

        MunicipioDetails GetId(int id);
    }
}
