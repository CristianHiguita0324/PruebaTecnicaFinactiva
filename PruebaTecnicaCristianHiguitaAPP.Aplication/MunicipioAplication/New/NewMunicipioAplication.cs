using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.New;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.New
{
    public class NewMunicipioAplication : INewMunicipioAplication
    {
        private readonly INewMunicipioDomain _newMunicipioDomain;
        public NewMunicipioAplication(INewMunicipioDomain newMunicipioDomain)
        {
            _newMunicipioDomain = newMunicipioDomain;
        }
        public ResponseService execute(MunicipioDto municipioDto)
        {
           return _newMunicipioDomain.execute(municipioDto);
        }
    }
}
