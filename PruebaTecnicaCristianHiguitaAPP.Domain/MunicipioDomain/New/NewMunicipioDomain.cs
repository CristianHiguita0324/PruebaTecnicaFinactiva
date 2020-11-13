using PruebaTecnicaCristianHiguitaAPP.Cross.Cls;
using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.New
{
    public class NewMunicipioDomain : INewMunicipioDomain
    {
        private readonly IUnitOfWork _unitOfWork;
        public NewMunicipioDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ResponseService execute(MunicipioDto municipioDto)
        {

            _unitOfWork.MunicipioRepository.Insert(createEntity(municipioDto));
            _unitOfWork.Save();
            return CreateResponseService.execute(Constant.CODIGO_EXITO,Constant.TRANSACCION_EXITOSA,null);
        }

        private TblMunicipio createEntity(MunicipioDto municipioDto)
        {
            return new TblMunicipio()
            {
                Estado = municipioDto.Estado,
                NombreMunicipio = municipioDto.NombreMunicipio
            };
        }
    }
}
