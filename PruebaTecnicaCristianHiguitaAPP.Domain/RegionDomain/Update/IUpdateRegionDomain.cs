using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.RegionDomain.Update
{
   public  interface IUpdateRegionDomain
    {
        ResponseService execute(RegionDto regionDto);
    }
}
