using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Delete
{
  public  interface IDeleteRegionAplication
    {
        ResponseService execute(int Idregion);
    }
}
