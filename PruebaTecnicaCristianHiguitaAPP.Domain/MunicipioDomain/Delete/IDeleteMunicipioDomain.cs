using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Delete
{
   public interface IDeleteMunicipioDomain
    {
        ResponseService execute(int id);
    }
}
