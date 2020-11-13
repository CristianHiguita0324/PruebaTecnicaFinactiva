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
        public bool execute(int id)
        {
            _unitOfWork.RegionMunicipioRepository.Delete(x => x.IdMunicipio.Equals(id));
            _unitOfWork.Save();
            _unitOfWork.MunicipioRepository.Delete(id);
            _unitOfWork.Save();
            return true;
        }
    }
}
