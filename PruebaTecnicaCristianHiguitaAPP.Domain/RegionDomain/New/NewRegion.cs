using Newtonsoft.Json;
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
        public string execute(string request)
        {

            TblRegion region = new TblRegion()
            {
                NombreRegion = request
            };
            _unitOfWork.RegionRepository.Insert(region);
            _unitOfWork.Save();

            return "Ok";
        }
    }
}
