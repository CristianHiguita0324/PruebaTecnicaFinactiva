using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Update
{
   public interface IUpdateMunicipioDomain
    {
        MunicipioDto execute(MunicipioDto municipioDto);
    }
}
