using Microsoft.EntityFrameworkCore.Internal;
using PruebaTecnicaCristianHiguitaAPP.Cross.Cls;
using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Cross.Exception_;
using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.RegionDomain.Search
{
    public class SearchRegionDomain : ISearchRegionDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        internal RegionesBDContext _context;
        public SearchRegionDomain(IUnitOfWork unitOfWork, RegionesBDContext bDContext)
        {
            _unitOfWork = unitOfWork;
            _context = bDContext;
        }
        

        public List<RegionDto> GetAll()
        {
          var ListRegion=   _unitOfWork.RegionRepository.GetAll();
            if (ListRegion != null)
            {
                List<RegionDto> list = new List<RegionDto>();
                foreach (var item in ListRegion)
                {
                    RegionDto region = new RegionDto()
                    {
                       IdRegion = item.IdRegion,
                       NombreRegion = item.NombreRegion
                    };
                    list.Add(region);
                }

                return list;
            }
            else
            {
                throw new BusinessException(Constant.SIN_INFORMACION);
            }
        }

        public RegionDetailsMunicipio GetID(int id)
        {
            var resp = _unitOfWork.RegionRepository.GetByID(id);
            RegionDetailsMunicipio regionDetails;
            if (resp != null)
            {
                regionDetails = (from x in _context.TblRegion
                                    join mr in _context.TblRegionMunicipio on x.IdRegion equals mr.Idregion
                                    join r in _context.TblMunicipio on mr.IdMunicipio equals r.IdMunicipio
                                    where x.IdRegion.Equals(id)
                                    select new RegionDetailsMunicipio()
                                    {

                                        IdRegion = x.IdRegion,
                                        NombreRegion = x.NombreRegion,
                                        municipios = (from rm in _context.TblRegionMunicipio
                                                      join r in _context.TblMunicipio on rm.IdMunicipio equals r.IdMunicipio
                                                      where rm.Idregion.Equals(x.IdRegion)
                                                      select new MunicipioDto()
                                                      {
                                                         IdMunicipio = r.IdMunicipio,
                                                         Estado = r.Estado,
                                                         NombreMunicipio = r.NombreMunicipio
                                                      }).Distinct().ToList()


                                    }).FirstOrDefault();

                _context.SaveChanges();

                if (regionDetails != null)
                    return regionDetails;
                else
                    return new RegionDetailsMunicipio() { IdRegion = resp.IdRegion, NombreRegion = resp.NombreRegion };
                
            }
            else
                return null;
        }
    }
}
