﻿using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Search
{
   public interface ISearchRegionAplication
    {
        List<RegionDto> GetAll();

        RegionDetailsMunicipio GetId(int id);
    }
}
