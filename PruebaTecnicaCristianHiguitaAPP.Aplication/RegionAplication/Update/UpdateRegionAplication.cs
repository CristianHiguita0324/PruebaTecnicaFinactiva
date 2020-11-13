using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Domain.RegionDomain.Update;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Update
{
    public class UpdateRegionAplication : IUpdateRegionAplication
    {
        private readonly IUpdateRegionDomain _updateRegionDomain;
        public UpdateRegionAplication(IUpdateRegionDomain updateRegionDomain)
        {
            _updateRegionDomain = updateRegionDomain;
        }
        public ResponseService execute(RegionDto regionDto)
        {
            return _updateRegionDomain.execute(regionDto);
        }
    }
}
