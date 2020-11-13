using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Update;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.MunicipioAplication.Update
{
    public class UpdatemunicipioAplication : IUpdatemunicipioAplication
    {
        private readonly IUpdateMunicipioDomain _updateMunicipioDomain;
        public UpdatemunicipioAplication(IUpdateMunicipioDomain updateMunicipioDomain)
        {
            _updateMunicipioDomain = updateMunicipioDomain;
        }
        public MunicipioDto execute(MunicipioDto municipioDto)
        {
            return _updateMunicipioDomain.execute(municipioDto);
        }
    }
}
