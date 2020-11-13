using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Domain.Region.Delete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Aplication.RegionAplication.Delete
{
    public class DeleteRegionAplication : IDeleteRegionAplication
    {
        private readonly IDeleteRegion _deleteRegion;

        public DeleteRegionAplication(IDeleteRegion deleteRegion)
        {
            _deleteRegion = deleteRegion;
        }
        public ResponseService execute(int Idregion)
        {
           return _deleteRegion.execute(Idregion);
        }
    }
}
