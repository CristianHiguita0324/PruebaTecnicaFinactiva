using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Update
{
    public class UpdateMunicipioDomain : IUpdateMunicipioDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        public UpdateMunicipioDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public MunicipioDto execute(MunicipioDto municipioDto)
        {
            if(!municipioDto.Estado)
            {
                _unitOfWork.RegionMunicipioRepository.Delete(x => x.IdMunicipio.Equals(municipioDto.IdMunicipio));
                _unitOfWork.Save();
            }
            _unitOfWork.MunicipioRepository.Update(createEntiti(municipioDto));
            _unitOfWork.Save();
            return null;
            //throw new NotImplementedException();
        }

        private TblMunicipio createEntiti(MunicipioDto municipioDto)
        {
            return new TblMunicipio()
            {
                Estado = municipioDto.Estado ,
                IdMunicipio = municipioDto.IdMunicipio,
                NombreMunicipio = municipioDto.NombreMunicipio
            };
        }
    }
}
