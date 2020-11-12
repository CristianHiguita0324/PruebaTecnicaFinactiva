using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork
{
   public interface IUnitOfWork : IDisposable
    {
        GenericRepository<TblMunicipio> MunicipioRepository { get; }
        GenericRepository<TblRegion> RegionRepository { get; }
        GenericRepository<TblRegionMunicipio> RegionMunicipioRepository { get; }
        void Save();
    }
}
