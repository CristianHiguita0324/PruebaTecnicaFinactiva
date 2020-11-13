using PruebaTecnicaCristianHiguitaAPP.Cross.Cls;
using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Delete;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.RegionDomain.Update
{
    public class UpdateRegionDomain : IUpdateRegionDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly IDeleteMunicipioDomain _deleteMunicipioDomain;
       
        public UpdateRegionDomain(IUnitOfWork unitOfWork, IDeleteMunicipioDomain deleteMunicipioDomain)
        {
            _unitOfWork = unitOfWork;
            _deleteMunicipioDomain = deleteMunicipioDomain;
          
        }
        public ResponseService execute(RegionDetails regionDto)
        {
            _unitOfWork.RegionRepository.Update(createEntity(regionDto));
            _unitOfWork.Save();

            if(regionDto.Municipios != null && regionDto.Municipios.Count >= 0)
            {
               return UpdateMunicipios(regionDto.Municipios, regionDto.IdRegion);
            }
            else
                return CreateResponseService.execute(Constant.CODIGO_EXITO, Constant.TRANSACCION_EXITOSA, null);


        }


        private ResponseService UpdateMunicipios(List<MunicipioRegion> list,int idRegion)
        {
            bool check = false;
            foreach (MunicipioRegion item in list)
            {
                if(item.EliminaAgrega.Equals("0"))
                {
                    _unitOfWork.RegionMunicipioRepository.Delete(X => X.IdMunicipio.Equals(item.IdMunicipio) && X.Idregion.Equals(idRegion));
                    _unitOfWork.Save();
                }
                else
                {
                  var a =  _unitOfWork.MunicipioRepository.GetByID(item.IdMunicipio);
                    _unitOfWork.Save();
                    if (a!=null && a.Estado)
                    {
                        _unitOfWork.RegionMunicipioRepository.Insert(CreateRelation(item.IdMunicipio, idRegion));
                        _unitOfWork.Save();
                    }
                    else
                    {
                        check = true;
                    }
                 
                }
            }

            return CreateResponseService.execute(Constant.CODIGO_EXITO, check ? Constant.MUNICIPIO_iNACTIVO: Constant.TRANSACCION_EXITOSA, new RegionDto());


        }

       private TblRegionMunicipio CreateRelation(int Idmunicipio, int IdRegion)
        {
            return new TblRegionMunicipio()
            {
                IdMunicipio = Idmunicipio,
                Idregion = IdRegion
            };
        }
        private TblRegion createEntity(RegionDto regionDto)
        {
            return new TblRegion()
            {
                IdRegion = regionDto.IdRegion,
                NombreRegion = regionDto.NombreRegion
            };
        }
    }
}
