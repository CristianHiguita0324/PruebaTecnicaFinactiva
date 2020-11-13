using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Domain.Region.New;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.New
{
    public class NewRegionAplication : INewRegionAplication
    {
        private readonly INewRegion _newRegion;
        public NewRegionAplication(INewRegion newRegion)
        {
            _newRegion = newRegion;
        }
        public ResponseService execute(string request)
        {
            return _newRegion.execute(request);
        }
    }
}
