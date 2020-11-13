using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.New
{
   public interface INewMunicipioDomain
    {
        ResponseService execute(MunicipioDto municipioDto);
    }
}
