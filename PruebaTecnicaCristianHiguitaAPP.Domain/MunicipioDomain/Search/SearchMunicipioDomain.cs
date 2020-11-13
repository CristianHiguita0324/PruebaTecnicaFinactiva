using PruebaTecnicaCristianHiguitaAPP.Cross.Cls;
using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Cross.Exception_;
using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Search
{
    public class SearchMunicipioDomain : ISearchMunicipioDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly RegionesBDContext _context;
        public SearchMunicipioDomain(IUnitOfWork unitOfWork, RegionesBDContext context)
        {
            _unitOfWork = unitOfWork;
            _context = context;
        }
        public List<MunicipioDto> GetAll()
        {
           var ListBd = _unitOfWork.MunicipioRepository.GetAll();

            if(ListBd != null)
            {
                List<MunicipioDto> list = new List<MunicipioDto>();
                foreach (var item in ListBd)
                {
                    MunicipioDto municipio = new MunicipioDto()
                    {
                        Estado = item.Estado,
                        IdMunicipio = item.IdMunicipio,
                        NombreMunicipio = item.NombreMunicipio
                    };
                    list.Add(municipio);
                }

                return list;
            }
            else
            {
                throw new BusinessException(Constant.SIN_INFORMACION);
            }
        }

        public MunicipioDetails GetId(int id)
        {
           var resp = _unitOfWork.MunicipioRepository.GetByID(id);
            MunicipioDetails municipioDetails;
            if (resp != null)
            {
                municipioDetails = (from x in _context.TblMunicipio
                        join mr in _context.TblRegionMunicipio on x.IdMunicipio equals mr.IdMunicipio
                        join r in _context.TblRegion on mr.Idregion equals r.IdRegion
                        where x.IdMunicipio.Equals(id)
                        select new MunicipioDetails()
                        {
                            Estado = x.Estado,
                            IdMunicipio = x.IdMunicipio,
                            NombreMunicipio = x.NombreMunicipio,
                            Regions = (from rm in _context.TblRegionMunicipio
                                       join r in _context.TblRegion on rm.Idregion equals r.IdRegion
                                       where rm.IdMunicipio.Equals(x.IdMunicipio)
                                       select new RegionDto()
                                       {
                                           IdRegion = rm.Idregion,
                                           NombreRegion = r.NombreRegion
                                       }).Distinct().ToList()

            }).FirstOrDefault();

                _context.SaveChanges();
                if (municipioDetails != null)
                    return municipioDetails;
                else
                    return new MunicipioDetails() { Estado = resp.Estado, IdMunicipio = resp.IdMunicipio, NombreMunicipio = resp.NombreMunicipio };
            }
            else
                return null;
            
        }
    }
}
