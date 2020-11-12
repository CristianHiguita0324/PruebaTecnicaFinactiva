using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork,IDisposable
    {
        private readonly RegionesBDContext _contexto;
        public GenericRepository<TblMunicipio> municipioRepository;

        public GenericRepository<TblRegion> regionRepository;

        public GenericRepository<TblRegionMunicipio> regionMunicipioRepository;

        public UnitOfWork(RegionesBDContext contexto)
        {
            _contexto = contexto;
        }
        public GenericRepository<TblMunicipio> MunicipioRepository
        {
            get
            {
                if (this.municipioRepository == null)
                {
                    this.municipioRepository = new GenericRepository<TblMunicipio>(_contexto);
                }
                return municipioRepository;
            }
        }


        public GenericRepository<TblRegion> RegionRepository
        {
            get
            {
                if (this.regionRepository == null)
                {
                    this.regionRepository = new GenericRepository<TblRegion>(_contexto);
                }
                return regionRepository;
            }
        }


        public GenericRepository<TblRegionMunicipio> RegionMunicipioRepository
        {
            get
            {
                if (this.regionMunicipioRepository == null)
                {
                    this.regionMunicipioRepository = new GenericRepository<TblRegionMunicipio>(_contexto);
                }
                return regionMunicipioRepository;
            }
        }

        public void Save()
        {
            _contexto.SaveChanges();
        }

        private bool disposed = false;

        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    _contexto.Dispose();
                }
            }
            this.disposed = true;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
