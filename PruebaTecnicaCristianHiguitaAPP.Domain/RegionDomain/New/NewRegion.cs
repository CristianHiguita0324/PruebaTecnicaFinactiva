using Newtonsoft.Json;
using PruebaTecnicaCristianHiguitaAPP.Cross.Cls;
using PruebaTecnicaCristianHiguitaAPP.Cross.Entities;
using PruebaTecnicaCristianHiguitaAPP.Data.Models;
using PruebaTecnicaCristianHiguitaAPP.Data.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Text;

namespace PruebaTecnicaCristianHiguitaAPP.Domain.Region.New
{
    public class NewRegion : INewRegion
    {
        private readonly IUnitOfWork _unitOfWork;
        public NewRegion(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public ResponseService execute(string request)
        {

            TblRegion region = new TblRegion()
            {
                NombreRegion = request
            };
            _unitOfWork.RegionRepository.Insert(region);
            _unitOfWork.Save();

            return CreateResponseService.execute(Constant.CODIGO_EXITO, Constant.TRANSACCION_EXITOSA, null);
        }
    }
}
