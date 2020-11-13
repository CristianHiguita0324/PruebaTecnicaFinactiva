using PruebaTecnicaCristianHiguitaAPP.Cross.Cls;
using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.MunicipioDomain.Delete
{
    public class DeleteMunicipioDomain : IDeleteMunicipioDomain
    {
        private readonly IUnitOfWork _unitOfWork;

        public DeleteMunicipioDomain(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ResponseService execute(int id)
        {
            _unitOfWork.RegionMunicipioRepository.Delete(x => x.IdMunicipio.Equals(id));
            _unitOfWork.Save();
            _unitOfWork.MunicipioRepository.Delete(id);
            _unitOfWork.Save();
            return CreateResponseService.execute(Constant.CODIGO_EXITO, Constant.TRANSACCION_EXITOSA, null); 
        }
    }
}
