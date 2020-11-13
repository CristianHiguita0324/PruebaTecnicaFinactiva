using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.Region.Delete
{
    public class DeleteRegion : IDeleteRegion
    {
        private readonly IUnitOfWork _unitOfWork;
        public DeleteRegion(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public bool execute(int Idregion)
        {
            _unitOfWork.RegionMunicipioRepository.Delete(x=> x.Idregion.Equals(Idregion));
            _unitOfWork.Save();
            _unitOfWork.RegionRepository.Delete(Idregion);
            _unitOfWork.Save();
            return true;
        }
    }
}
