using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.Region.Delete
{
   public interface IDeleteRegion
    {
        ResponseService execute(int Idregion);
    }
}
