using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Update
{
   public interface  IUpdateRegionAplication
    {
        ResponseService execute(RegionDetails regionDto);
    }
}
